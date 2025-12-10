
bars = document.querySelector('.bars-icon');
menuDetail = document.querySelector('.menu-detail');

bars.onclick = function () {
    menuDetail.classList.toggle('active');
}