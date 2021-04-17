const userForm = document.getElementById('userForm');

const inputs = document.querySelectorAll('input');


document.getElementById('submitBtn').addEventListener('click', (evt) => {
  evt.preventDefault();
  let isValid = userForm.checkValidity();
  userForm.reportValidity();

  if (isValid) {
    printPerson();
  }
  else {
    printError();
  }
  document.getElementById('textBtn').addEventListener('click', (evt) => {
    evt.target.parentNode.style.display = 'none';
  })
})

function printPerson() {

  const info = printInfo()

  const selectInput = document.getElementById('country');
  let html = `
        <h2>Честито! Регистрирахте се успешно!</h2>
        <p>
          ${inputs[0].value}<br>
          ${inputs[1].value}<br>
          ${inputs[2].value}, ${selectInput.value} <br>
          Потребителско име: ${inputs[3].value}<br>
          Имейл: ${inputs[4].value}<br>
        </p>
        
  `
  info.style.backgroundColor = "green";

  info.innerHTML = html;
  userForm.reset();
}

function printError() {
  const info = printInfo();
  info.style.display = "block"
  let html = `
        <h2>Имате неправилно въведени данни</h2>
        <p>
          Проверете дали всички полета са попълнени спрямо изискванията по-долу:
          <ul>
            <li>Името трябва да съдържа между 4 и 50 букви;</li>
            <li>Адресът трябва да съдържа между 10 и 30 символа;</li>
            <li>Пощенският код трябва да е с дължина 4 цифри;</li>
            <li>Потребителското име може да съдържа: букви, цифри и специални символи ! # $ % ^ & * . , @ ; : ~ - _ +;</li>
            <li>Валиден имейл адрес.</li>
          </ul>
        </p>`
  info.style.backgroundColor = "red"
  info.innerHTML = html;
}

function printInfo() {

  const formCoords = userForm.getBoundingClientRect();
  const info = document.getElementById('info');

  info.style.top = formCoords.top + "px";
  info.style.left = (formCoords.right + 30) + "px";
  info.style.display = "block";

  return info;
}