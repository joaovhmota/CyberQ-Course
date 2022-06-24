document.addEventListener('change', function() {
	var imgs = document.getElementsByTagName('img');
	
	for (i = 0; i < imgs.length; ++i) 
		imgs.item(i).loading = 'lazy';
});