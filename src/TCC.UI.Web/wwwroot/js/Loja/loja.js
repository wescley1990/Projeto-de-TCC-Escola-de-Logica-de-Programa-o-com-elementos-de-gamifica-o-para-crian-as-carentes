function verificarAlturaItens() {
    var tabela = document.querySelector(".item-table");
    var alturaItens = tabela.scrollHeight;
    var alturaVisivel = tabela.clientHeight;

    if (alturaItens > alturaVisivel) {
      
        tabela.scrollTop = alturaItens - alturaVisivel;
    }
}


window.addEventListener("load", verificarAlturaItens);


window.addEventListener("resize", verificarAlturaItens);