using TestePloomesAPI.Dao;
using TestePloomesAPI.Model;

namespace TestePloomesAPI.Repos
{
    public class PessoaRepositorio
    {
        private readonly DaoPessoa daoPessoa;

        public PessoaRepositorio()
        {
            daoPessoa = new DaoPessoa();
        }
        public List<Pessoa> GetPessoas
        {
            get
            {
                return daoPessoa.GetPessoas();
            }
        }

        public void InsertPessoa(Pessoa pessoa)
        {
            daoPessoa.InsertPessoa(pessoa);
        }
    }
}
