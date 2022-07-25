using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVerbos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista2 : ContentPage
    {
        public Lista2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        List<Verb> lista2_verbos = new List<Verb>()
        {
            new Verb("freeze")
            {
                past_tense = "froze",
                past_participle = "frozen",
                traducao = "congelar"
            },

            new Verb("get")
            {
                past_tense = "got",
                past_participle = "got",
                traducao = "obter, chegar, receber"
            },

            new Verb("give")
            {
                past_tense = "gave",
                past_participle = "given",
                traducao = "dar"
            },

            new Verb("go")
            {
                past_tense = "went",
                past_participle = "gone",
                traducao = "ir"
            },

            new Verb("grind")
            {
                past_tense = "ground",
                past_participle = "ground",
                traducao = "moer"
            },

            new Verb("grow")
            {
                past_tense = "grew",
                past_participle = "grown",
                traducao = "crescer, cultivar"
            },

            new Verb("hang")
            {
                past_tense = "hung",
                past_participle = "hung",
                traducao = "pendurar"
            },

            new Verb("have")
            {
                past_tense = "had",
                past_participle = "had",
                traducao = "ter"
            },

            new Verb("hear")
            {
                past_tense = "heard",
                past_participle = "heard",
                traducao = "ouvir"
            },

            new Verb("hide")
            {
                past_tense = "hide",
                past_participle = "hidden",
                traducao = "esconder"
            },

            new Verb("hit")
            {
                past_tense = "hit",
                past_participle = "hit",
                traducao = "bater, atingir"
            },

            new Verb("hold")
            {
                past_tense = "held",
                past_participle = "held",
                traducao = "segurar, abraçar"
            },

            new Verb("hurt")
            {
                past_tense = "hurt",
                past_participle = "hurt",
                traducao = "ferir, magoar"
            },

            new Verb("keep")
            {
                past_tense = "kept",
                past_participle = "kept",
                traducao = "conservar, guardar"
            },

            new Verb("kneel")
            {
                past_tense = "knelt",
                past_participle = "knelt",
                traducao = "ajoelhar-se"
            },

            new Verb("knit")
            {
                past_tense = "knit",
                past_participle = "knit",
                traducao = "tricotar"
            },

            new Verb("know")
            {
                past_tense = "knew",
                past_participle = "known",
                traducao = "saber, conhecer"
            },

            new Verb("lay")
            {
                past_tense = "laid",
                past_participle = "laid",
                traducao = "pôr, colocar"
            },

            new Verb("lead")
            {
                past_tense = "led",
                past_participle = "led",
                traducao = "levar, conduzir"
            },

             new Verb("lean")
            {
                past_tense = "leant",
                past_participle = "leant",
                traducao = "inclinar-se, encostar"
            },

              new Verb("leap")
            {
                past_tense = "leapt",
                past_participle = "leapt",
                traducao = "pular, saltar"
            },

               new Verb("learn")
            {
                past_tense = "learned",
                past_participle = "learned",
                traducao = "aprender"
            },

            new Verb("leave")
            {
                past_tense = "left",
                past_participle = "left",
                traducao = "abandonar, partir"
            },

            new Verb("lend")
            {
                past_tense = "lent",
                past_participle = "lent",
                traducao = "emprestar (para)"
            },

            new Verb("let")
            {
                past_tense = "let",
                past_participle = "let",
                traducao = "deixar, permitir"
            },

            new Verb("lie")
            {
                past_tense = "lay",
                past_participle = "lain",
                traducao = "deitar-se, jazer, estar situado"
            },

            new Verb("light")
            {
                past_tense = "lighted",
                past_participle = "lighted",
                traducao = "acender"
            },

            new Verb("lose")
            {
                past_tense = "lost",
                past_participle = "lost",
                traducao = "perder"
            },

            new Verb("make")
            {
                past_tense = "made",
                past_participle = "made",
                traducao = "fazer"
            },

            new Verb("mean")
            {
                past_tense = "meant",
                past_participle = "meant",
                traducao = "significar"
            },

            new Verb("meet")
            {
                past_tense = "met",
                past_participle = "met",
                traducao = "encontrar, conhecer"
            },

            new Verb("mow")
            {
                past_tense = "mowed",
                past_participle = "mowed",
                traducao = "cortar plantas"
            },

            new Verb("pay")
            {
                past_tense = "paid",
                past_participle = "paid",
                traducao = "pagar"
            },

            new Verb("put")
            {
                past_tense = "put",
                past_participle = "put",
                traducao = "pôr"
            },

            new Verb("quit")
            {
                past_tense = "quit",
                past_participle = "quit",
                traducao = "desistir, abandonar"
            },

            new Verb("read")
            {
                past_tense = "read",
                past_participle = "read",
                traducao = "ler"
            },

            new Verb("ride")
            {
                past_tense = "rode",
                past_participle = "ridden",
                traducao = "andar de carro, bicicleta"
            },

            new Verb("ring")
            {
                past_tense = "rang",
                past_participle = "rung",
                traducao = "tocar, soar"
            },

            new Verb("rise")
            {
                past_tense = "rose",
                past_participle = "risen",
                traducao = "levantar-se, aumentar, subir"
            },

            new Verb("run")
            {
                past_tense = "ran",
                past_participle = "run",
                traducao = "correr"
            },

            new Verb("saw")
            {
                past_tense = "sawed",
                past_participle = "sawed",
                traducao = "serrar"
            },

            new Verb("say")
            {
                past_tense = "said",
                past_participle = "said",
                traducao = "dizer"
            },

            new Verb("see")
            {
                past_tense = "saw",
                past_participle = "saw",
                traducao = "ver"
            },

            new Verb("seek")
            {
                past_tense = "sought",
                past_participle = "sought",
                traducao = "procurar"
            },

            new Verb("seel")
            {
                past_tense = "sold",
                past_participle = "sold",
                traducao = "vender"
            },

            new Verb("send")
            {
                past_tense = "sent",
                past_participle = "sent",
                traducao = "enviar"
            },

            new Verb("set")
            {
                past_tense = "set",
                past_participle = "set",
                traducao = "pôr, instalar"
            },

            new Verb("sew")
            {
                past_tense = "sewed",
                past_participle = "sewed",
                traducao = "costurar"
            },

            new Verb("shake")
            {
                past_tense = "shook",
                past_participle = "shoken",
                traducao = "sacudir, tremer"
            },

            new Verb("shed")
            {
                past_tense = "shed",
                past_participle = "shed",
                traducao = "derramar, verter"
            },

            new Verb("shine")
            {
                past_tense = "shone",
                past_participle = "shone",
                traducao = "brilhar"
            },

            new Verb("shoot")
            {
                past_tense = "shot",
                past_participle = "shot",
                traducao = "atirar, disparar"
            },

            new Verb("show")
            {
                past_tense = "showed",
                past_participle = "shown",
                traducao = "mostrar"
            },

            new Verb("shrink")
            {
                past_tense = "shrank",
                past_participle = "shrunk",
                traducao = "encolher"
            },
        };

        /***
        * 
        *  Função que verifica se as entradas correspondem à palavra correta do verbo   
        *     
        */
        private void Button_Clicked(object sender, EventArgs e)
        {
            string past = Input_Past.Text.Trim();
            string participle = Input_Participle.Text.Trim();

            int i = int.Parse(Index_Verbo.Text);

            if (past == lista2_verbos[i].past_tense)
            {
                Resultado_Past.Text = "O Passado simples " + past + " está correto!";
            }
            else
            {
                Resultado_Past.Text = "O Passado simples " + past + " está incorreto!, o correto seria: " + lista2_verbos[i].past_tense;
            }

            if (participle == lista2_verbos[i].past_participle)
            {
                Resultado_Participle.Text = "O Particípio " + participle + " está correto!";
            }
            else
            {
                Resultado_Participle.Text = "O Particípio  " + participle + " está incorreto!, o correto seria: " + lista2_verbos[i].past_participle;
            }

        }

        /***
        * 
        *  Função que mostra um verbo na tela aleatoriamente   
        *     
        */
        private void Comecar(object sender, EventArgs e)
        {
            Random num = new Random();

            int i = num.Next(0, 55);

            string msg = "Qual o passado simples e o participio do verbo to " + lista2_verbos[i].nome + "(" + lista2_verbos[i].traducao + ")?";

            Mensagem.Text = msg;
            Input_Participle.Text = "";
            Input_Past.Text = "";
            Resultado_Participle.Text = "";
            Resultado_Past.Text = "";
            Index_Verbo.Text = i.ToString();
        }
    }
}