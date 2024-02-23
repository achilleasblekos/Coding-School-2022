// Exercise 1
function reverseString() {
  var originalString = document.getElementById("name").value;
  var reversedString = "";

  for (var i = originalString.length - 1; i >= 0; i--) {
    reversedString += originalString[i];
  }

  document.getElementById("reversed").value = reversedString;
}

// Exercise 2
function pallindrome() {
  var string = document.getElementById("txtString").value.split("");
  var checkbox = document.getElementById("checkPallindrome");

  for (var i = 0; i < string.length / 2 + 1; i++) {
    if (string[i] !== string[string.length - 1 - i]) {
      checkbox.checked = false;
      return false;
    }

    checkbox.checked = true;
  }
}

// Exercise 3
function addCustomer() {
  var customerTable = document.getElementById("customerTable");
  var customerForm = document.getElementById("customerForm");
  var selectedCustomerForm = document.getElementById("selectedCustomer");
  var customerName = document.getElementById("cname").value;
  var customerSurname = document.getElementById("csurname").value;
  var customerAge = document.getElementById("cage").value;
  var customerGender = document.getElementById("cgender").value;
  var customerTemplate = `
                <tr onclick="loadSelectedCustomer(this)">
                    <td>${customerName}</td>
                    <td>${customerSurname}</td>
                    <td>${customerAge}</td>
                    <td>${customerGender}</td>
                </tr>
    `;

  customerTable.innerHTML += customerTemplate;
  customerForm.reset();
  selectedCustomerForm.reset();
}

function loadSelectedCustomer(e) {
  var selectedName = e.children[0];
  var selectedSurname = e.children[1];
  var selectedAge = e.children[2];
  var selectedGender = e.children[3];

  document.getElementById("sname").value = selectedName.innerText;
  document.getElementById("ssurname").value = selectedSurname.innerText;
  document.getElementById("sage").value = selectedAge.innerText;
  document.getElementById("sgender").value = selectedGender.innerText;
}

// Exercise 4
// Όπως είπαμε και στο μάθημα η παρακάτω function θα δουλέψει κανονικά
// όπως έχει. Ωστόσο το μόνο που θα μπορούσαμε να αλλάξουμε είναι να προσθέσουμε
// ένα έλεγχο για το αν αυτό που περνάμε είναι αριθμοί.
function multiply(a, b) {
  return a * b;
}

// Exercise 5
function increaseLastDigit(text) {
  var string = text;
  // Create the regular expressions for testing the string against
  var numberReg = /[0-9]+$/;
  var alphaReg = /[a-zA-Z]+$/;

  if (numberReg.test(string)) {
    let newString = string.replace(numberReg, function (x) {
      return parseInt(x) + 1;
    });
    return newString;
  }

  if (alphaReg.test(string)) {
    let newString = string.replace(alphaReg, function (x) {
      return x + "1";
    });
    return newString;
  }
}
