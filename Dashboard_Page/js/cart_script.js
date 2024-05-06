const cartItems = document.getElementById('cart-items');
const checkoutBtn = document.getElementById('checkout-btn');
const totalPrice = document.getElementById('total-price');

const productPrice = document.getElementById('productPrice');

let cart = [];

async function fetchProducts() {
    const response = await fetch('./json/products.json');
    const products = await response.json();
    return products;
}

function addToCart(product) {
    cart.push(product);
    renderCart();
}

function removeFromCart(index) {
    cart.splice(index, 1);
    renderCart();
}

function renderCart() {
    cartItems.innerHTML = '';
    let total = 0;

    cart.forEach((product, index) => {
        const cartItem = document.createElement('li');
        cartItem.classList.add('list-group-item', 'cart-item');

        const cartItemContent = `
            <div class="d-flex justify-content-between cart-item">
                <div>
                    <img src="${product.image}" alt="${product.name}" class="me-3">
                </div>

                <div class="cart-item-details">
                    <h5>${product.name}</h5>
                    <p>$${product.price}</p>
                </div>

                <div>
                    <button class="btn btn-danger remove-btn" data-index="${index}">
                        Remove
                    </button>
                </div>
            </div>
        `;

        cartItem.innerHTML = cartItemContent;
        cartItems.appendChild(cartItem);

        total += product.price;
    });

    // totalPrice.textContent = `$${total}`;
    totalPrice.innerText = total;
   
    productPrice.innerText = total;


    const removeBtns = document.querySelectorAll('.remove-btn');
    removeBtns.forEach(btn => btn.addEventListener('click', () => removeFromCart(btn.dataset.index)));
}

async function initCart() {
    const products = await fetchProducts();

    products.forEach(product => {
        addToCart(product);
    });

    // addToCart(products[0]);
    // addToCart(products[1]);
    // addToCart(products[2]);
    // addToCart(products[3]);

    renderCart();
}

initCart();