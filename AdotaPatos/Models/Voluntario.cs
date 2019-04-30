using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdotaPatos.Models
{
    public class Voluntario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        //public string CartaoVacina { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        //public string Observacao1 { get; set; }
        //public string Observacao2 { get; set; }
        //public DateTime DataAdesaoAdotaPatos { get; set; }
        public string Dia { get; set; }
        public string Turno { get; set; }
        public string Doacao { get; set; }
        public string ServicoAjuda { get; set; }

        public Voluntario(int id, string nome,/* string nacionalidade, string naturalidade,*/ string sexo, string estadoCivil, DateTime dataNascimento, string rg, string cpf, string profissao,/* string cartaoVacina,*/ string endereco, string cep, string cidade, string uf, string telefone, string email,/* string observacao1, string observacao2,*/ string dataAdesaoAdotaPatos, string dia, string turno, string doacao, string servicoAjuda)
        {
            Id = id;
            Nome = nome;
            //Nacionalidade = nacionalidade;
            //Naturalidade = naturalidade;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Profissao = profissao;
            //CartaoVacina = cartaoVacina;
            Endereco = endereco;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
            Telefone = telefone;
            Email = email;
            //Observacao1 = observacao1;
            //Observacao2 = observacao2;
            //DataAdesaoAdotaPatos = dataAdesaoAdotaPatos;
            Dia = dia;
            Turno = turno;
            Doacao = doacao;
            ServicoAjuda = servicoAjuda;
        }

        public Voluntario()
        {

        }
    }
}