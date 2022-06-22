var currenType = "C";
let temperature = 0.0;
const emC = document.getElementById("emC");
const emF = document.getElementById("emF");
const convertButton = document.getElementById("convertButton");
const numTemp = document.getElementById("numTemp");

convertButton.addEventListener("click", () => {
	switch (currenType) {
		case "C":
			temperature = ( parseFloat(numTemp.value) * 1.8) + 32;
			break;
		
		case "F":
			temperature = ( parseFloat(numTemp.value) - 32) / 1.8;
			break;
	}
	numTemp.value = temperature;
});

emC.addEventListener("click", () => {
	currenType = "C";
	emC.classList = "btn btn-outline-success";
	emF.classList = "btn btn-outline-secondary";
});

emF.addEventListener("click", () => {
	currenType = "F";
	emC.classList = "btn btn-outline-secondary";
	emF.classList = "btn btn-outline-success";
});