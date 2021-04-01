const photos = ["2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg"];
const imagePath = "image/";

const element = document.getElementById("imageHolder");
element.src = imagePath + photos[0];

const nav = document.querySelector(".navigation");

for (let i = 0; i < photos.length; i++) {
    const circle = createNavigator(photos[i], element);

    if (i == 0) circle.setAttribute("class", "active");
    nav.appendChild(circle);
}

function createNavigator(url, element) {
    const square = document.createElement("span");

    square.onclick = (event) => {
        element.src = imagePath + url;
        const circles = document.querySelectorAll(".navigation span");
        circles.forEach(e => { e.setAttribute("class", "")})

        event.target.setAttribute("class", "active");
    }
    return square;
}