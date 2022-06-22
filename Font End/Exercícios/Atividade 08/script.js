// https://pokeapi.co/api/v2/pokemon?limit=10228
// https://pokeapi.co/api/v2/type?limit=50

const pokemonDisplay = document.getElementById("pokemonDisplay");
const selectTypes = document.getElementById("selectTypes");
const amountToShow = document.getElementById("amountToShow");
const searchButton = document.getElementById("searchButton");
const pokemonName = document.getElementById("pokemonName");
const shinyButton = document.getElementById("shinyButton");

let pokemons = [];	
let pokemonTypes = [];
var limit = 150;

async function getPokemons() {
	pokemons = [];
	await fetch(`https://pokeapi.co/api/v2/pokemon?limit=${limit}`)
			.then(pokemonsStr => pokemonsStr.json())
			.then(jsonPokemon => pokemons.push(jsonPokemon.results));

	pokemons = pokemons[0];
	await console.table(pokemons);

	pokemonDisplay.innerHTML = "";
}

async function showAllPokemons() {
	await getPokemons();
	try {
		await pokemons.forEach( async p => {
			var pokemonSprite = "";
			var currentType = ["", ];
			
			if (p.name.includes(pokemonName.value))
				await fetch(`https://pokeapi.co/api/v2/pokemon/${pokemons.indexOf(p) + 1}`)
					.then(jsonStr => jsonStr.json())
					.then(jsonInfo => {
						pokemonSprite = jsonInfo.sprites.front_default;
						jsonInfo.types.forEach( t => {
							currentType.push(t.type.name);
						});
						
						console.log(currentType);
						if (currentType.includes(selectTypes.value))
							pokemonDisplay.innerHTML += 
								`
								<div class="col-3">
									<div class="card" >
										<img loading="lazy" src="${pokemonSprite}">
										<div class="card-body">
											<h5 class="card-title"> ${p.name} </h5>
											<h6 class="card-subtitle"> ${currentType.join(" ")} </h6>
										</div>
									</div>
								</div>
								`;
						
					});
		});
	} catch (ex) { console.error(ex); }
}

async function showAllShinyPokemons(name, type) {
	await getPokemons();
	try {
		await pokemons.forEach( async p => {
			var pokemonSprite = "";
			var currentType = ["", ];
			
			if (p.name.includes(pokemonName.value))
				await fetch(`https://pokeapi.co/api/v2/pokemon/${pokemons.indexOf(p) + 1}`)
					.then(jsonStr => jsonStr.json())
					.then(jsonInfo => {
						pokemonSprite = jsonInfo.sprites.front_shiny;
						jsonInfo.types.forEach( t => {
							currentType.push(t.type.name);
						});
						
						console.log(currentType);
						if (currentType.includes(selectTypes.value))
							pokemonDisplay.innerHTML += 
								`
								<div class="col-3">
									<div class="card" >
										<img loading="lazy" src="${pokemonSprite}">
										<div class="card-body">
											<h5 class="card-title"> ${p.name} </h5>
											<h6 class="card-subtitle"> ${currentType.join(" ")} </h6>
										</div>
									</div>
								</div>
								`;
						
					});
		});
	} catch (ex) { console.error(ex); }
}

async function loadTypesSelect() {
	await fetch("https://pokeapi.co/api/v2/type?limit=50")
			.then(types => types.json())
			.then(jsonTypes => pokemonTypes.push(jsonTypes.results));
	
	pokemonTypes = pokemonTypes[0];
	await console.table(pokemonTypes);
	await setTypesSelect()
}

async function setTypesSelect() {
	pokemonTypes.forEach( t => {
		selectTypes.innerHTML += `<option value="${t.name}"> ${t.name} </option>`;
	});
}

window.onload = async () => {
	await loadTypesSelect();
	await showAllPokemons("");
}

searchButton.addEventListener("click", async () => {
	limit = amountToShow.value;

	if (limit == 0) limit = 1126;

	showAllPokemons(pokemonName.value);
});

shinyButton.addEventListener("click", async () => {
	limit = amountToShow.value;

	if (limit == 0) limit = 1126;

	showAllShinyPokemons();
});