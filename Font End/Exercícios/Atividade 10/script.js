const apiKey = 'def164cebead43108e9142013222306';
const btnShowWeather = document.getElementById('btnShowWeather');
const txtCityName = document.getElementById('txtCityName');
const displayCards = document.getElementById('displayCards');

btnShowWeather.addEventListener('click', () => {
	try {
		fetch(`http://api.weatherapi.com/v1/current.json?key=${apiKey}&q=${txtCityName.value}`)
			.then(strWeather => strWeather.json())
			.then(jsonWeather => {
				// Hoje
				displayCards.innerHTML += 
				`<div class="col-3">
					<div class="card" style="width: 16rem;">
						<img src="${jsonWeather.current.condition.icon}" class="card-img-top" alt="">
						<div class="card-body">
							<h5 class="card-title"> ${jsonWeather.current.condition.text} ${jsonWeather.current.temp_c}°C </h5>
							<p class="card-text"> Humidity: ${jsonWeather.current.humidity}% </p>
						</div>
					</div>
				</div>
				`;
			});
	} catch (e) { console.error(e); }
});
