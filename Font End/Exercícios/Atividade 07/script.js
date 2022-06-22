const states = document.getElementById("states");
const showCities = document.getElementById("showCities");
const cities = document.getElementById("cities");

var fetchedInfo = [];

async function getInfo() {
	await fetch(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/${states.value}/distritos`)
		.then(info => info.json())
		.then(jsonInfo => fetchedInfo = jsonInfo);

	await console.table(fetchedInfo);

	await updateTable();
}

async function updateTable() {
	cities.innerHTML = "";

	fetchedInfo.forEach( c => {
		let row;
		let c1, c2, c3;

		row = cities.insertRow(-1);

		c1 = row.insertCell(0);
		c2 = row.insertCell(1);
		c3 = row.insertCell(2);

		c1.innerText = `${c.id}`;
		c2.innerText = `${fetchedInfo.indexOf(c) + 1}`;
		c3.innerText = `${c.nome}`;
	});
}

showCities.addEventListener("click", async () => {
	await getInfo();
});