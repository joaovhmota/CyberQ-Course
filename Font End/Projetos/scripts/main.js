'use strict';
//#region HTML Elements
const tableProducts = document.getElementById('tableProducts');
const txtProductName = document.getElementById('txtProductName');
const btnSearchProducts = document.getElementById('btnSearchProducts');
const productCategorySelect = document.getElementById('productCategorySelect');
const numAddCart = document.getElementById('numAddCart');
const btnConfirmAddToCart = document.getElementById('btnConfirmAddToCart');
const btnCancelAddToCart = document.getElementById('btnCancelAddToCart');
const cartTableProducts = document.getElementById('cartTableProducts');
//#endregion

//#region Variables
var allProducts = [];
var allCategories = [];
var cartProducts = [];
var startFrom = 0;
var currentProductIndex = -1;
//#endregion

//#region Events
window.onload = async () => {
	allProducts = [];
	await fetch('https://ralflima.com/api/produtos.json')
		.then(str => str.json())
		.then(fetchedJson => allProducts.push(fetchedJson));
	
	allProducts = allProducts[0];
	await setCategories();
	await resetCartProducts();
}

document.addEventListener('keypress', (key) => {
	if (key.key == "Enter") updateTableProducts();
});

btnSearchProducts.addEventListener('click', () => {
	updateTableProducts();
});

//#endregion

//#region Functions
async function resetCartProducts() {
	allProducts.forEach( p => {
		cartProducts.push({
			code: p.codigo,
			amount: 0,
			total: 0.0
		});
	});
}

async function updateTableProducts() {
	// console.table(allProducts);
	tableProducts.innerHTML = '';

	allProducts.forEach( p => {
		if (p.nome.trim().toLowerCase().includes(txtProductName.value.toLowerCase()))
			if (p.categoria.includes(productCategorySelect.value))
				tableProducts.innerHTML += 
				`
					<tr>
						<td> <img loading="lazy" class="roundProduct" src="${p.imagem}" alt="${p.nome}" style="width: 8rem;"> </td>
						<td class="tableProductName"> ${p.nome} </td>
						<td> ${parseFloat(p.valor).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td>
						<td class="productCategory" > ${p.categoria} </td>
						<td> ${p.estoque} </td>
						<td> <button class="btn btn-outline-dark" onclick="selectProduct(${p.codigo - 1})" data-bs-toggle="modal" data-bs-target="#staticBackdrop"> Adicionar ao carrinho </button> </td>
					</tr>
				`;
	});
}

async function setCategories() {
	allProducts.forEach( p => {
		if (!allCategories.includes(p.categoria)) {
			productCategorySelect.innerHTML += `<option value="${p.categoria}"> ${p.categoria} </option>`;
			allCategories.push(p.categoria);
		}
	});
}

function selectProduct(i) {
	currentProductIndex = i;
}

function addToCart() {
	if (parseInt(numAddCart.value) > allProducts[currentProductIndex].estoque) return;
	cartProducts[currentProductIndex].amount += parseInt(numAddCart.value);
	allProducts[currentProductIndex].estoque -= parseInt(numAddCart.value);
	
	cartProducts[currentProductIndex].total = cartProducts[currentProductIndex].amount * parseFloat(allProducts[currentProductIndex].valor);

	currentProductIndex = -1;
	numAddCart.value = "";

	// console.table(cartProducts);

	updateTableProducts();	
	updateCartProductsTable();
}

function updateCartProductsTable() {
	cartTableProducts.innerHTML = '';
	cartProducts.forEach( i => {
		if (i.amount > 0)
			cartTableProducts.innerHTML += 
			`
				<tr>
					<td> <img loading="lazy" class="roundProduct" src="${allProducts[i.code - 1].imagem}" alt="${allProducts[i.code - 1].nome}" style="width: 8rem;"> </td>
					<td class="tableProductName"> ${allProducts[i.code - 1].nome} </td>
					<td> ${parseFloat(i.total).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td>
					<td> ${i.amount} </td>
					<td> <button class="btn btn-outline-danger"> Remover do Carrinho</button> </td>
				</tr>
			`;
	});
}

//#endregion