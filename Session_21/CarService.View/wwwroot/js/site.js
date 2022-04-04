// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function NewServiceTaskValidation() {
    let formInputs = document.querySelectorAll("select");
    if (formInputs[0].selectedIndex == 0 || formInputs[1].selectedIndex == 0 || formInputs[2].selectedIndex == 0) {
        prompt(`${formInputs[0].selectedIndex}\n ${formInputs[1].selectedIndex}\n${formInputs[2].selectedIndex}`);
        return false;
    }
    return true;
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