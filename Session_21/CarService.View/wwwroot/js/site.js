// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function NewTask2() {
    document.forms["Transaction"].action = "/Transaction/AddTask";
    document.forms["Transaction"].submit();
}


function NewTask() {
    let formInputs = document.querySelectorAll("select");
    let carId = formInputs[0].options[formInputs[0].selectedIndex].value;
    let customerId = formInputs[1].options[formInputs[1].selectedIndex].value;
    let managerId = formInputs[2].options[formInputs[2].selectedIndex].value;

    fetch('/Transaction/AddTask?' + new URLSearchParams({
        CarId: carId,
        CustomerID: customerId,
        ManagerID: managerId
    }),
        {
            method: "POST"
        })
        .then(function (response) {
        return response.text()
    })
        .then(function (html) {
            document.body.innerHTML = html;
        })
        .catch(function (err) {
            console.log('Failed to fetch page: ', err);
        });
}