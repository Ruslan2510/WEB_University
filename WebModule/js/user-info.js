window.onload = function () {
    const submitButton = document.getElementById("form-submit");
    let statements = [];

    console.log(submitButton);
    console.log(document);

    const userName = document.getElementById("form-name");
    let user = {};
    userName&&userName.addEventListener('blur', function(event) {
        user.name = event.target.value;
    });

    const userTel = document.getElementById("form-tel");
    userTel&&userTel.addEventListener('blur', function(event) {
        user.tel = event.target.value;
    });

    const userAddress = document.getElementById("form-adress");
    userAddress&&userAddress.addEventListener('blur', function(event) {
        user.address = event.target.value;
    });

    submitButton&&submitButton.addEventListener('click', function() {
        statements.push(user);
        localStorage.setItem('statements', JSON.stringify(statements));
    });


    const showButton = document.getElementById("show-statements");
    const showDiv = document.getElementById("show-div");

    showButton&&showButton.addEventListener('click', function() {
        let statements = JSON.parse(localStorage.getItem('statements'));
        for (let i = 0; i < statements.length; i++) {
            showDiv.innerHTML = `<div class='statement'><p>Имя: ${statements[i].name}</p><p>Телефон: ${statements[i].tel}</p><p>Адрес:${statements[i].address}</p></div>`;
        }
    });
}