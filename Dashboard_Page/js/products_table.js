document.addEventListener('DOMContentLoaded', function() {
    // Fetch products from JSON file
    function fetchProducts() {
        fetch('./json/products_table.json')
            .then(response => response.json())
            .then(data => renderProducts(data))
            .catch(error => console.error('Error loading JSON file:', error));
    }

    // Render products in the table
    function renderProducts(products) {
        const productList = document.querySelector('#product-list tbody');
        productList.innerHTML = '';

        products.forEach(product => {
            productList.innerHTML += `
                <tr>
                    <td>${product.id}</td>
                    <td>${product.productName}</td>
                    <td>${product.price}</td>
                    <td>
                        <button class="btn btn-primary edit-product-btn" data-id="${product.id}">Edit</button>
                        <button class="btn btn-danger delete-product-btn" data-id="${product.id}">Delete</button>
                    </td>
                </tr>
            `;
        });
    }

    // Handle adding or editing products
    function handleSaveProduct() {
        const productName = document.getElementById('product-name').value;
        const price = document.getElementById('product-price').value;
        const productId = document.getElementById('product-id').value;

        if (productId) {
            // Edit existing product
            const row = document.querySelector(`#product-list tr[data-id="${productId}"]`);
            row.innerHTML = `
                <td>${productId}</td>
                <td>${productName}</td>
                <td>${price}</td>
                <td>
                    <button class="btn btn-primary edit-product-btn" data-id="${productId}">Edit</button>
                    <button class="btn btn-danger delete-product-btn" data-id="${productId}">Delete</button>
                </td>
            `;
        } else {
            // Add new product
            const productList = document.querySelector('#product-list tbody');
            const id = productList.children.length + 1;
            productList.innerHTML += `
                <tr data-id="${id}">
                    <td>${id}</td>
                    <td>${productName}</td>
                    <td>${price}</td>
                    <td>
                        <button class="btn btn-primary edit-product-btn" data-id="${id}">Edit</button>
                        <button class="btn btn-danger delete-product-btn" data-id="${id}">Delete</button>
                    </td>
                </tr>
            `;
        }

        const productModal = new bootstrap.Modal(document.getElementById('product-modal'));
        productModal.hide();
    }

    // Handle editing product
    function handleEditProduct(event) {
        if (event.target.classList.contains('edit-product-btn')) {
            const id = event.target.dataset.id;
            const row = document.querySelector(`#product-list tr[data-id="${id}"]`);
            const productName = row.children[1].textContent;
            const price = row.children[2].textContent;

            document.getElementById('product-id').value = id;
            document.getElementById('product-name').value = productName;
            document.getElementById('product-price').value = price;

            const productModal = new bootstrap.Modal(document.getElementById('product-modal'));
            productModal.show();
        }
    }

    // Handle deleting product
    function handleDeleteProduct(event) {
        if (event.target.classList.contains('delete-product-btn')) {
            const id = event.target.dataset.id;
            const row = document.querySelector(`#product-list tr[data-id="${id}"]`);
            row.remove();
        }
    }

    // Event listeners
    document.getElementById('add-product-btn').addEventListener('click', function() {
        const productModal = new bootstrap.Modal(document.getElementById('product-modal'));
        productModal.show();
    });

    document.getElementById('save-product-btn').addEventListener('click', handleSaveProduct);
    document.addEventListener('click', handleEditProduct);
    document.addEventListener('click', handleDeleteProduct);

    // Initial load of products
    fetchProducts();
});
