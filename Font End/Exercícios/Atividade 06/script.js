const txtCEP = document.getElementById("txtCEP");
const btnGetInfo = document.getElementById("btnGetInfo");
const clearTable = document.getElementById("clearTable");
const infoTable = document.getElementById("infoTable");
var fetchedInfo = [];


btnGetInfo.addEventListener("click", async () => {
	// alert(txtCEP.value);

	await fetch(`https://viacep.com.br/ws/${txtCEP.value}/json/`)
		.then(cep => cep.json())
		.then(fetched => fetchedInfo.push(fetched))
				
	await console.table(fetchedInfo);

	await UpdateTable();
});

clearTable.addEventListener("click", () => {
	infoTable.innerHTML = "";
});

async function UpdateTable() {
	let row;
	let c1, c2, c3, c4, c5, c6;

	infoTable.innerHTML = "";

	fetchedInfo.forEach( i => {
		row = infoTable.insertRow(-1);

		c1 = row.insertCell(0);
		c2 = row.insertCell(1);
		c3 = row.insertCell(2);
		c4 = row.insertCell(3);
		c5 = row.insertCell(4);
		c6 = row.insertCell(5);
		
		c1.innerText = `${i.cep}`;
		c2.innerText = `${i.logradouro}`;
		c3.innerText = `${i.complemento}`;
		c4.innerText = `${i.bairro}`;
		c5.innerText = `${i.localidade}`;
		c6.innerText = `${i.uf}`;
	});

	console.log(1 + "1");
	txtCEP.value = "";
}