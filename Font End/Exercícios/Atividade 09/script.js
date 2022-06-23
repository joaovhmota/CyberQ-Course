const coins = [
	'BTC', // Bitcoin
	'ETH', // Etherium
	'AXS', // Axie Infinity
	'DOGE' // Dogecoin
];

const coinNames = [
	'Bitcoin',
	'Etherium',
	'Axie Infinity',
	'Dogecoin'
];

const htmlToast = document.getElementById('warningToast')
const toast = new bootstrap.Toast(htmlToast);;

const coinDisplay = document.getElementById('coinDisplay');
var timer;

window.onload = () => {
	toast.show();
	displayCoins();
	try {
		timer = setInterval( () => {
			displayCoins();
		}, 15000);
	} catch (e) {clearInterval(timer)}
}

async function displayCoins() {
	coinDisplay.innerHTML = "";
	coins.forEach( c => {
		fetch(`https://www.mercadobitcoin.net/api/${c}/ticker/`)
			.then(strCoin => strCoin.json())
			.then(jsonCoin => {
				coinDisplay.innerHTML += 
				`
					<div class="col-3">
						<div class="card" style="width: 18rem;">
							<div class="card-body">
								<h5 class="card-title"> ${coinNames[coins.indexOf(c)]} </h5>
								<h6 class="card-subtitle"> ${c} </h6>
								<p class="card-text"> ${parseFloat(jsonCoin.ticker.last).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </p>
							</div>
						</div>
					</div>
				`;
			})
			.catch( () => { clearInterval(timer); } );
	});
}