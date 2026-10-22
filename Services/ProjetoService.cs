using GerenciadorAcademico2.Models;
using GerenciadorAcademico2.ViewModels;

namespace GerenciadorAcademico2.Services
{
    public class ProjetoService
    {
        private readonly List<Projeto> _projetos = new();
        private int _proximoId = 1;

        public List<Projeto> ObterTodos() => _projetos;

        public void Adicionar(NovoProjetoViewModel vm)
        {
            _projetos.Add(new Projeto
            {
                Id = _proximoId++,
                Titulo = vm.Titulo,
                Descricao = vm.Descricao,
                CargaHoraria = vm.CargaHoraria
            });
        }

    }
}
