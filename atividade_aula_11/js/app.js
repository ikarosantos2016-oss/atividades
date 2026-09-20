const livros = [
    {id: 1, titulo: "Harry Potter e a Pedra Filosofal", autor: "J. K. Rowling", categoria: "Fantasia", total: 15, emprestados: 15, ativo: true},
    {id: 2, titulo: "Harry Potter e a Câmara Secreta", autor: "J. K. Rowling", categoria: "Fantasia", total: 20, emprestados: 5, ativo: true},
    {id: 3, titulo: "Harry Potter e o Prisioneiro de Azkaban", autor: "J. K. Rowling", categoria: "Fantasia", total: 25, emprestados: 6, ativo: true},
    {id: 4, titulo: "Harry Potter e o Cálice de Fogo", autor: "J. K. Rowling", categoria: "Fantasia", total: 30, emprestados: 7, ativo: true}
];

function calcularDisponiveis(livro){
    return livro.total - livro.emprestados;
}

//console.log("Quantidade disponivel", calcularDisponiveis(livros[2]));

const filtroLivros = livros.filter((livro) => {
    return livro.ativo === true && calcularDisponiveis(livro) > 0;
});

//console.table(filtroLivros);

const resumos = livros.map((livro) =>{
    return {
        titulo: livro.titulo,
        disponibilidade: calcularDisponiveis(livro)
    };
});

//console.table(resumos);

const livroEncontrado = livros.find((livro) =>{
    return livro.id ===2;
});

//console.table(livroEncontrado);

const livroEsgotado = livros.some((livro) => {
    return calcularDisponiveis(livro) === 0;
});

//console.log(`log de teste ${livroEsgotado ? "teste 1" : "teste 2"}`);

const possuiAutor = livros.every((livro) => {
    return livro.autor.length > 0;
});

//console.log(`Teste de livro com autor: ${possuiAutor ? "Todos os livros possuem autor!" : "Algum livro não possui autor!"}`);