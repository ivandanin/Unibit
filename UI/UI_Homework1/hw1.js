const paragraphs =
["It was about 11 o'clock in the morning.",
"I was wearing my powder-blue suit.",
"I was everything the well-dressed private detective ougth to be.",
"I was calling on four million dollars.",
"The main hallway of the Sternwood was two stories high."]


function createParagraphs(selector, paragraphs){
  
  let textContainer = document.querySelector(selector)
    for(let i =0; i<paragraphs.length;i++){
    let paragraph = document.createElement("p");
    paragraph.textContent = paragraphs[i];

    textContainer.appendChild(paragraph);
  }
}

function createH3s(selector){
  const headers = document.querySelectorAll(selector);
  const paragraphs = document.querySelectorAll("section.text p") 

  for (let i = 0; i < paragraphs.length; i++) {
    headers[i].textContent = paragraphs[i].textContent;
  }
}

function setRandomColor(elements){
    const randomColor =Math.floor(Math.random()*16777215).toString(16);
    for (let i = 0; i < elements.length; i++) {
      elements[i].style.color = `#${randomColor}`;    
    }
  }

createParagraphs(".text", paragraphs);

const createH3Button = document.createElement("button");
createH3Button.textContent = "Create H3s"
createH3Button.onclick = ()=> 
  {
    createH3s("section.headings h3");
    document.getElementById("colorButton").style.display = "block";
  };
const textSection = document.querySelector(".text");
textSection.appendChild(createH3Button);

const colorButton = document.createElement("button");
colorButton.textContent = "Randomize color"
colorButton.id = "colorButton";
colorButton.onclick = ()=> setRandomColor(document.querySelectorAll("section.headings h3"));
colorButton.style.display = "none";
document.body.appendChild(colorButton);