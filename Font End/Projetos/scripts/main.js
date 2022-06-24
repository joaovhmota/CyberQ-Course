//#region HTML Elements
const tableProducts = document.getElementById('tableProducts');
const txtProductName = document.getElementById('txtProductName');
const btnSearchProducts = document.getElementById('btnSearchProducts');
const productCategorySelect = document.getElementById('productCategorySelect');
const numAddCart = document.getElementById('numAddCart');
const btnConfirmAddToCart = document.getElementById('btnConfirmAddToCart');
const btnCancelAddToCart = document.getElementById('btnCancelAddToCart');
const cartTableProducts = document.getElementById('cartTableProducts');
const numRemoveCart = document.getElementById('numRemoveCart');
const finalTable = document.getElementById('finalTable');
const cpfInNote = document.getElementById('cpfInNote');
const txtCPF = document.getElementById('txtCPF');
const btnEndShopping = document.getElementById('btnEndShopping');
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
	await updateTableProducts();
}

document.addEventListener('keyup', (key) => {
	updateTableProducts();
});

productCategorySelect.addEventListener('change', () => {
	updateTableProducts();
});

cpfInNote.addEventListener('change', () => {
	if (cpfInNote.checked) {
		txtCPF.disabled = false;
		txtCPF.required = true;
	}
	else {
		txtCPF.disabled = true;	
		txtCPF.required = false;
	}
});

txtCPF.addEventListener('change', () => {
	strCPF = txtCPF.value;
	if (strCPF.length == 14) { return; }
	if (strCPF.length != 11 || /[a-zA-Z]/.test(txtCPF.value)) {
		txtCPF.value = '';
		return;
	}

	strMasked = '';
	strMasked = `${strCPF[0]}${strCPF[1]}${strCPF[2]}.${strCPF[3]}${strCPF[4]}${strCPF[5]}.${strCPF[6]}${strCPF[7]}${strCPF[8]}-${strCPF[9]}${strCPF[10]}`;
	txtCPF.value = strMasked;
});

btnEndShopping.addEventListener('click', () => {
	resetCartProducts();
	updateCartProductsTable();
	updateFinalTable()

	document.getElementById('txtClientName').value = '';
	txtCPF.value = '';
	cpfInNote.checked = false;
	txtCPF.disabled = true;
});

//#endregion

//#region Functions
async function resetCartProducts() {
	cartProducts = [];
	allProducts.forEach( p => {
		cartProducts.push({
			code: p.codigo,
			amount: 0,
			total: 0.0
		});
	});
}

async function updateTableProducts() {
	tableProducts.innerHTML = '';

	allProducts.forEach( p => {
			if (p.nome.trim().toLowerCase().includes(txtProductName.value.toLowerCase()))
				if (p.categoria.includes(productCategorySelect.value))
					if (p.estoque > 0)
						tableProducts.innerHTML += 
						`
							<tr>
								<td> <img loading="lazy" class="roundProduct" src="${p.imagem}" alt="${p.nome}" style="width: 7rem;"> </td>
								<td class="tableProductName"> ${p.nome} </td>
								<td> ${parseFloat(p.valor).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td>
								<td class="productCategory" > ${p.categoria} </td>
								<td> ${p.estoque} </td>
								<td> <button class="btn btn-outline-success" onclick="selectProduct(${p.codigo - 1})" data-bs-toggle="modal" data-bs-target="#addToCartModal"> Adicionar ao carrinho </button> </td>
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
	if (parseInt(numAddCart.value) > allProducts[currentProductIndex].estoque || parseInt(numAddCart.value) < 0) {
		numAddCart.value = "";
		return;
	}
	cartProducts[currentProductIndex].amount += parseInt(numAddCart.value);
	allProducts[currentProductIndex].estoque -= parseInt(numAddCart.value);
	
	cartProducts[currentProductIndex].total = cartProducts[currentProductIndex].amount * parseFloat(allProducts[currentProductIndex].valor);

	currentProductIndex = -1;
	numAddCart.value = "";

	updateTableProducts();
	updateCartProductsTable();
	updateFinalTable();
}

function updateCartProductsTable() {
	cartTableProducts.innerHTML = '';
	cartProducts.forEach( i => {
		if (i.amount > 0)
			cartTableProducts.innerHTML += 
			`
				<tr>
					<td> <img class="roundProduct" src="${allProducts[i.code - 1].imagem}" alt="${allProducts[i.code - 1].nome}" style="width: 8rem;"> </td>
					<td class="tableProductName"> ${allProducts[i.code - 1].nome} </td>
					<td> ${parseFloat(i.total).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td>
					<td> ${i.amount} </td>
					<td> <button class="btn btn-outline-danger" data-bs-toggle="modal" data-bs-target="#removeFromCartModal" onclick="selectProduct(${i.code - 1})"> Remover do Carrinho</button> </td>
				</tr>
			`;
	});
}

function updateFinalTable() {
	var finalTotal = 0;
	finalTable.innerHTML = '';

	cartProducts.forEach( i => {
		finalTotal += i.total;
		if (i.amount > 0)
			finalTable.innerHTML += 
			`
				<tr class="finalTableRow">
					<td class="tableProductName"> ${allProducts[i.code - 1].nome} </td>
					<td> ${parseFloat(i.total).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td>
					<td> ${i.amount} </td>
				</tr>
			`;
	});
	document.getElementById('finalTableTotal').innerHTML = `<tr> <td colspan="3" > Total: ${parseFloat(finalTotal).toLocaleString('pt-br', {style: 'currency', currency: 'BRL'})} </td> </tr>`;
	
}

function removeFromCart() {
	if (parseInt(numRemoveCart.value) > cartProducts[currentProductIndex].amount || parseInt(numRemoveCart.value) < 0) {
		numRemoveCart.value = '';
		return;
	}

	cartProducts[currentProductIndex].amount -= parseInt(numRemoveCart.value);
	allProducts[currentProductIndex].estoque += parseInt(numRemoveCart.value)

	cartProducts[currentProductIndex].total = cartProducts[currentProductIndex].amount * parseFloat(allProducts[currentProductIndex].valor);

	updateTableProducts();
	updateCartProductsTable();

	numRemoveCart.value = '';
	updateFinalTable();
}

//#endregion