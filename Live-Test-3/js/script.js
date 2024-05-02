$.get("https://dummyjson.com/products", function(products){
    products.forEach(function(product){
        var productCard = `
            <div class="col-md-4 mb-3">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">${product.name}</h5>
                        <p class="card-text">Price: $${product.price}</p>
                    </div>
                </div>
            </div>
        `;
        $("#product-list").append(productCard);
    });
});
