const registeredPeople = [
	{
		"name": "Rei da Sinuca", 
		"age": 17,
		"city": "Pomerode"
	},
	{
		"name": "William 5 Galinhas", 
		"age": 20,
		"city": "Pomerode"
	},
	{
		"name": "Henrique", 
		"age": 16,
		"city": "Blumenau"
	},
	{
		"name": "Aeges", 
		"age": 19,
		"city": "Blumenau"
	},
	{
		"name": "Ottecas", 
		"age": 19,
		"city": "Blumenau"
	},
	{
		"name": "Samuca", 
		"age": 17,
		"city": "Blumenau"
	},
	{
		"name": "Pimenta", 
		"age": 17,
		"city": "Blumenau"
	}
];
//#region Variables
var selectIndex;
const btnAdd = document.getElementById("btnAdd");
const btnUpdate = document.getElementById("btnUpdate");
const btnRemove = document.getElementById("btnRemove");
const btnCancel = document.getElementById("btnCancel");
const tablePeopleBody = document.getElementById("tablePeopleBody");
//#endregion

//#region Custom Functions
function updateTable() {
	registeredPeople.sort();

	let linha, c1, c2, c3, c4, c5;
	tablePeopleBody.innerHTML = "";

	registeredPeople.forEach( p => {
		linha = tablePeopleBody.insertRow(-1);
		
		c1 = linha.insertCell(0);
		c2 = linha.insertCell(1);
		c3 = linha.insertCell(2);
		c4 = linha.insertCell(3);
		c5 = linha.insertCell(4);

		c1.innerText = registeredPeople.indexOf(p) + 1;
		c2.innerText = p.name;
		c3.innerText = p.age;
		c4.innerText = p.city;
		c5.innerHTML = `<button class="btn btn-outline-danger" onclick="selectPerson(${registeredPeople.indexOf(p)})"> Selecionar </button>`;
	});

	clearFields();
}

function clearFields() {
	document.getElementById("txtName").value = "";
	document.getElementById("numAge").value = "";
	document.getElementById("txtCity").value = "";

	document.getElementById("btnAdd").style.display = "inline-block";
	document.getElementById("btnUpdate").style.display = "none";
	document.getElementById("btnRemove").style.display = "none";
}

function selectPerson(i) {
	selectIndex = i;

	document.getElementById("btnAdd").style.display = "None";
	document.getElementById("btnUpdate").style.display = "inline-block";
	document.getElementById("btnRemove").style.display = "inline-block";

	document.getElementById("txtName").value = registeredPeople[i].name;
	document.getElementById("numAge").value = registeredPeople[i].age;
	document.getElementById("txtCity").value = registeredPeople[i].city;
}

//#endregion

//#region Events
window.onload = function() {
	updateTable();
	document.getElementById("btnUpdate").style.display = "none";
	document.getElementById("btnRemove").style.display = "none";
}

btnAdd.addEventListener("click", function() {
	var personName = document.getElementById("txtName").value;
	var personAge = parseInt(document.getElementById("numAge").value);
	var personCity = document.getElementById("txtCity").value;

	if (registeredPeople.includes({ "name": personName, "age": personAge, "city": personCity})) return;

	registeredPeople.push({
		"name": personName, 
		"age": personAge,
		"city": personCity
	});

	console.clear();
	console.table(registeredPeople);
	updateTable();
});

btnUpdate.addEventListener("click", function() {
	var personName = document.getElementById("txtName").value;
	var personAge = parseInt(document.getElementById("numAge").value);
	var personCity = document.getElementById("txtCity").value;

	registeredPeople[selectIndex] = {
		"name": personName, 
		"age": personAge,
		"city": personCity
	};

	updateTable();
	clearFields();
});

btnRemove.addEventListener("click", function() {
	registeredPeople.splice(selectIndex, 1);
	selectIndex = null;

	updateTable();
});

btnCancel.addEventListener("click", function() {
	clearFields();
});
//#endregion