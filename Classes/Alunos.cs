namespace sistema_de_cadastro_de_alunos.Classes
{
    public class Alunos
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaAluno(){
            return this.mediaFinal;
        }
        public float VerMesalidade(){

            float valor;

            if(this.bolsista == true && this.mediaFinal >= 8){
                valor = this.valorMensalidade * 0.5f; //50% da mensalidade
            }else{
                valor = this.valorMensalidade;
            }
            
            return valor;
        }
    }
}