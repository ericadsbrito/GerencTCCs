﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using DTO;

namespace Negocios
{
    public class AlunoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
		
		public string Inserir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoNome", aluno.AlunoNome);
                acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", aluno.AlunoMatricula);
                acessoDadosSqlServer.AdicionarParametros("@AlunoTelefone", aluno.AlunoTelefone);
				acessoDadosSqlServer.AdicionarParametros("@AlunoCursoID", aluno.AlunoCursoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO tblAluno (AlunoNome,AlunoMatricula,AlunoTelefone,AlunoCursoID) VALUES (@AlunoNome,@AlunoMatricula,@AlunoTelefone,@AlunoCursoID) SELECT @@IDENTITY AS RETORNO").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoID", aluno.AlunoID);
                acessoDadosSqlServer.AdicionarParametros("@AlunoNome", aluno.AlunoNome);
                acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", aluno.AlunoMatricula);
                acessoDadosSqlServer.AdicionarParametros("@AlunoTelefone", aluno.AlunoTelefone);
				acessoDadosSqlServer.AdicionarParametros("@AlunoCursoID", aluno.AlunoCursoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "UPDATE tblAluno SET AlunoNome = @AlunoNome, AlunoMatricula = @AlunoMatricula, AlunoTelefone = @AlunoTelefone, AlunoCursoID = @AlunoCursoID WHERE AlunoID = @AlunoID SELECT @AlunoID AS RETORNO").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@AlunoID", aluno.AlunoID);
                string AlunoID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "DELETE FROM tblAluno WHERE AlunoID = @AlunoID SELECT @AlunoID AS RETORNO").ToString();

                return AlunoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public AlunoColecao ConsultarPorNome(string nome)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            AlunoColecao alunoColecao = new AlunoColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoNome", nome);
            DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT AlunoID AS ID, AlunoNome AS Aluno, AlunoMatricula AS Matricula, AlunoTelefone AS Telefone, CursoID AS CursoID, CursoNome AS Curso, UnidadeNome AS Unidade FROM tblAluno INNER JOIN tblCurso ON AlunoCursoID = CursoID INNER JOIN tblUnidade ON CursoUnidadeID = UnidadeID WHERE AlunoNome LIKE '%' + @AlunoNome + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableAluno.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Aluno aluno = new Aluno();
                aluno.AlunoID = Convert.ToInt32(linha["ID"]);
                aluno.AlunoNome = Convert.ToString(linha["Aluno"]);
                aluno.AlunoMatricula = Convert.ToString(linha["Matricula"]);
                aluno.AlunoTelefone = Convert.ToString(linha["Telefone"]);
                aluno.AlunoCursoID = Convert.ToInt32(linha["CursoID"]);
				aluno.AlunoCursoNome = (linha["Curso"]).ToString();
                aluno.AlunoUnidadeNome = Convert.ToString(linha["Unidade"]);
                alunoColecao.Add(aluno);
            }
            return alunoColecao;
        }

        public AlunoColecao ConsultarPorMatricula(string matricula)
        {
            //Criar uma nova coleção de clientes (aqui ela está vazia)
            AlunoColecao alunoColecao = new AlunoColecao();

            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", matricula);
            DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT AlunoID AS ID, AlunoNome AS Aluno, AlunoMatricula AS Matricula, AlunoTelefone AS Telefone, CursoID AS CursoID, CursoNome AS Curso, UnidadeNome AS Unidade FROM tblAluno INNER JOIN tblCurso ON AlunoCursoID = CursoID INNER JOIN tblUnidade ON CursoUnidadeID = UnidadeID WHERE AlunoMatricula LIKE '%' + @AlunoMatricula + '%'");

            //Percorrer o DataTable e transformar em coleção de cliente
            //Cada linha do DataTable é um cliente
            foreach (DataRow linha in dataTableAluno.Rows)
            {
                //Criar um cliente vazio
                //Colocar os dados da linha dele
                //Adicionar ele na coleção
                Aluno aluno = new Aluno();
                aluno.AlunoID = Convert.ToInt32(linha["ID"]);
                aluno.AlunoID = Convert.ToInt32(linha["ID"]);
                aluno.AlunoNome = Convert.ToString(linha["Aluno"]);
                aluno.AlunoMatricula = Convert.ToString(linha["Matricula"]);
                aluno.AlunoTelefone = Convert.ToString(linha["Telefone"]);
                aluno.AlunoCursoID = Convert.ToInt32(linha["CursoID"]);
                aluno.AlunoCursoNome = (linha["Curso"]).ToString();
                aluno.AlunoUnidadeNome = Convert.ToString(linha["Unidade"]);
                alunoColecao.Add(aluno);
            }
            return alunoColecao;
        }

        public int VerificarAlunoExistente(string matricula, int alunoid)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoMatricula", matricula);
            acessoDadosSqlServer.AdicionarParametros("@AlunoID", alunoid);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT AlunoID FROM tblAluno WHERE AlunoMatricula = @AlunoMatricula AND AlunoID <> @AlunoID"));

            return verificacao;
        }

        public int VerificarUso(int alunoid)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@AlunoID", alunoid);
            int verificacao = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.Text, "SELECT TOP 1 AlunoID FROM tblAluno INNER JOIN tblTCC ON AlunoID = TCCAlunoID WHERE AlunoID = @AlunoID and TCCID > '0'"));
            return verificacao;
        }
    }
}
