/*Interple essa interface criada como um contrato para receber os jogadores.
Etão toda nova classe jogador deve erdar essa interface.
EX: public class jogador1 : iJogador*/
namespace GameTOP.Interface
{
    public interface iJogador
    {
         string Corre();
         string Chuta();
         string Passe();
    }
}