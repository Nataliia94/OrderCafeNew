// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
    // for details on configuring this project to bundle and minify static web assets.
    // Write your JavaScript code.


        function sum() {
               var amount = document.getElementById('txtAmount').value;
               var price = document.getElementById('txtunitPrice').value;
               var result = parseFloat(amount) * parseFloat(price);
               if (!isNaN(result)) {
                   document.getElementById('txtTotalPrice').value = result;
               }
         }
        


   