var height = 10, width = 10;
var r = 0;
	var g = 0;
	var b = 0;
var x = 1, y = 1;
var hitBot = false, hitRight = false;
var i = 1;


window.onload = () => {
	setInterval( () => {

		// r = 255;
		// g = 255;
		// b = 255;

		if (b == 0) r++;
		if (r > 255) r = 255;

		if (r == 255) g++
		if (g > 255) g = 255;

		if (g == 255) b++;
		if (b > 255) b = 255;

		if (b == 255) r--;
		if (r < 0) r = 0;

		if (r == 0) g--;
		if (g < 0) g = 0;

		if (g == 0) b--;
		if (b < 0) b = 0;

		try
		{
			var e = document.getElementById(`ball${i - 100}`).remove();
		} catch (e) {}
		document.body.innerHTML += 
		`<div id="ball${i}" class="ball" style="top: ${y}px; left: ${x}px; height: ${height}px; width: ${width}px; background-color: rgb(${r}, ${g}, ${b});">
		
		</div>
		`;
		
		if (x >= 2123)
			hitBot = true;
		if (x <= 1)
			hitBot = false;
		if (y >= 1190)
			hitRight = true;
		if (y <= 1)
		 	hitRight = false;

		if (hitBot)
			x--
		if (!hitBot)
			x++
		
		if (hitRight)
			y--
		if (!hitRight)
			y++


		i++;
	}, 1);
}