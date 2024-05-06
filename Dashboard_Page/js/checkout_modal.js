

document.getElementById('applyDiscount').addEventListener('click', function(){
    console.log('Button Clicked : Apply');
    debugger;
    // const totalPriceCart = document.getElementById('total-price');
    // const priceCart = parseFloat(totalPriceCart.innerText);

    // const productPrice = document.getElementById('productPrice');
    // productPrice.innerText = priceCart;

     const productPricePrevious = parseFloat(productPrice.innerText);
    // const productPricePrevious = productPrice;

    const discountCouponCode = document.getElementById('discountCoupon');
    const CouponCode = discountCouponCode.value;

    if(CouponCode == 'dis30'){
        const discount = (productPricePrevious * (30/100));
        const discountedPrice = (productPricePrevious - discount);

        const productPriceFinal = document.getElementById('finalPrice');
        productPriceFinal.innerText = discountedPrice;
    }
    else{
        alert('invalid Discount Coupon');

        const productPriceFinal = document.getElementById('finalPrice');
        productPriceFinal.innerText = productPricePrevious;
    }

    console.log(productPricePrevious, discountedPrice )
})

document.getElementById('checkout-btn').addEventListener('click', function(){
    const checkout_Modal = new bootstrap.Modal(document.getElementById('checkout-modal'));
    checkout_Modal.show();
})


document.getElementById('order-btn').addEventListener('click', function(){
    alert("Order Successful.\nMake Payment.")
});
