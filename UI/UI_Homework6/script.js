function init() {
    let addLi = document.getElementById('addLiBtn');
    let list = document.getElementById('list');
    let count = 1;
    let showParent = document.getElementById('showParentBtn');
    let parentEl = document.getElementById('parentEl');
    let showFChild = document.getElementById('showFirstChildBtn');
    let showFElChild = document.getElementById('showFirstElChildBtn');
    let showLChild = document.getElementById('showLChildBtn');
    let showNextSibling = document.getElementById('showNextSiblingBtn')
    let showNextElSibling = document.getElementById('showNextElSiblingBtn')
    let showPreviousSibling = document.getElementById('showPreviousSiblingBtn')
    let showPreviousElSibling = document.getElementById('showPreviousElSiblingBtn')
    
    let createLi = () => {
        let li = document.createElement('li');
        list.appendChild(li);
        li.innerHTML = count;
        count++;
    }

    let getParent = () => {
        let parent = list.parentNode.nodeName;
        let childEl = list.childNodes.length;
        parentEl.innerHTML = `Parent element is ${parent} and have ${childEl} elements(1 'ul' and ${childEl - 1} 'li')`;
    }

    let getFirstChild = () => {
        list.firstChild.innerHTML = 1;
        let first = list.firstChild.innerHTML;
        parentEl.innerHTML = `The first child is ${first}.`;
    }

    let getFirstElChild = () => {
        let firstEl = list.firstElementChild.innerHTML;
        parentEl.innerHTML = `The first element child is ${firstEl}.`;
    }

    let getLastChild = () => {
        let last = list.lastChild.innerHTML;
        parentEl.innerHTML = `The last child is ${last}.`;
    }

    let getNextSibling = () => {
        let last = list.lastChild.innerHTML;
        list.nextSibling.innerHTML = count;
        let next = list.nextSibling.innerHTML;
        parentEl.innerHTML = `The next sibling of ${last} is ${next}.`;
    }

    let getNextElSibling = () => {
        let last = list.lastChild.innerHTML;
        list.nextSibling.innerHTML = count;
        let nextEl = list.nextSibling.innerHTML;
        parentEl.innerHTML = `The next element sibling of ${last} is ${nextEl}.`;
    }

    let getPreviousSibling = () => {
        let prevSibling = list.lastChild.innerHTML - 1;
        parentEl.innerHTML = `The previous sibling is ${prevSibling}.`;
    }

    let getPreviousElSibling = () => {
        let prevElSibling = list.lastChild.innerHTML - 1;
        parentEl.innerHTML = `The previous element sibling is ${prevElSibling}.`;
    }

    addLi.onclick = () => { createLi() }
    showParent.onclick = () => { getParent() }
    showFChild.onclick = () => { getFirstChild() }
    showFElChild.onclick = () => { getFirstElChild() }
    showLChild.onclick = () => { getLastChild() }
    showNextSibling.onclick = () => { getNextSibling() }
    showNextElSibling.onclick = () => { getNextElSibling() }
    showPreviousSibling.onclick = () => { getPreviousSibling() }
    showPreviousElSibling.onclick = () => { getPreviousElSibling() }
}

init();