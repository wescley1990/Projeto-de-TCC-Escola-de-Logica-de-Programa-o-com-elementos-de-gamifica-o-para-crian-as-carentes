const comprar1 = document.getElementById('comprar');
const comprar2 = document.getElementById('comprar2');
const comprar3 = document.getElementById('comprar3');
const comprar4 = document.getElementById('comprar4');
const comprar5 = document.getElementById('comprar5');
const comprar6 = document.getElementById('comprar6');
const modal = document.getElementById('myModal');
const modal2 = document.getElementById('myModal2');
const confirmButton = document.getElementById('confirmButton');
const cancelButton = document.getElementById('cancelButton');

comprar1.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar1.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar2.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar2.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar2.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar2.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar3.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar3.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar4.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar4.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar5.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar5.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

comprar6.addEventListener('click', function (e) {
    e.preventDefault();
    modal.style.display = 'flex';
});

comprar6.addEventListener('click', function (e) {
    e.preventDefault();
    modal2.style.display = 'flex';
});

confirmButton.addEventListener('click', function () {
    alert('Compra realizada com sucesso!');
    modal.style.display = 'none';
});
cancelButton.addEventListener('click', function () {
    alert('Compra cancelada.');
    modal.style.display = 'none';
});