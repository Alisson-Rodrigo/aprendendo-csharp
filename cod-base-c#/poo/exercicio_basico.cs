using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
    class Program {
        static void Main() {
            var cursos = new Cursos("Informática", "Curso de informática", 200);
            var aluno = new Aluno("João", 20, cursos);
            var aluno2 = new Aluno("Maria", 22, cursos);
            aluno.ExibirInfo();
            Console.WriteLine("");
            aluno2.ExibirInfo();
        
        }
    class Aluno {
        public string nome{get; set;}
        public int idade{get;}
        public Cursos cursos{get; set;}

        public Aluno(string nome, int idade, Cursos cursos){
            this.nome = nome;
            this.idade = idade;
            this.cursos = cursos;
        }

        public void ExibirInfo () {
            Console.WriteLine(this.idade);
            Console.WriteLine(this.nome);
            this.cursos.ExibirInfo();
        }


    }

    class Cursos {
        public string nome{get; set;}
        public string descricao{get; set;}
        public int cargaHoraria{get; set;}

        public Cursos(string nome, string descricao, int cargaHoraria){
            this.nome = nome;
            this.descricao = descricao;
            this.cargaHoraria = cargaHoraria;
        }

        public void ExibirInfo () {
            Console.WriteLine(this.nome);
            Console.WriteLine(this.descricao);
            Console.WriteLine(this.cargaHoraria);
        }







        }
    }
}