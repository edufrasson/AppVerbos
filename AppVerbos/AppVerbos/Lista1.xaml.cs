using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace AppVerbos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        List<Verb> lista1_verbos = new List<Verb>()
        {
            new Verb("arise")
            {
                past_tense = "arose",
                past_participle = "arisen",
                traducao = "surgir, levantar-se"
            },

            new Verb("awake")
            {
                past_tense = "awoke",
                past_participle = "awoken",
                traducao = "despertar"
            },

            new Verb("be")
            {
                past_tense = "was",
                past_participle = "been",
                traducao = "ser, estar"
            },

            new Verb("bear")
            {
                past_tense = "bore",
                past_participle = "born",
                traducao = "suportar, dar à luz"
            },

            new Verb("beat")
            {
                past_tense = "beat",
                past_participle = "beater",
                traducao = "bater, derrotar"
            },

            new Verb("become")
            {
                past_tense = "became",
                past_participle = "become",
                traducao = "tornar-se"
            },

            new Verb("begin")
            {
                past_tense = "began",
                past_participle = "begun",
                traducao = "começar"
            },

            new Verb("bend")
            {
                past_tense = "bent",
                past_participle = "bent",
                traducao = "curvar-se, dobrar"
            },

            new Verb("bet")
            {
                past_tense = "bet",
                past_participle = "bet",
                traducao = "apostar"
            },

            new Verb("bind")
            {
                past_tense = "bound",
                past_participle = "bound",
                traducao = "amarrar, obrigar, encadernar"
            },

            new Verb("bite")
            {
                past_tense = "bit",
                past_participle = "bitten",
                traducao = "morder"
            },

            new Verb("bleed")
            {
                past_tense = "bled",
                past_participle = "blied",
                traducao = "sangrar"
            },

            new Verb("blow")
            {
                past_tense = "blew",
                past_participle = "blown",
                traducao = "soprar"
            },

            new Verb("break")
            {
                past_tense = "broke",
                past_participle = "broken",
                traducao = "quebrar"
            },

            new Verb("bring")
            {
                past_tense = "brought",
                past_participle = "brought",
                traducao = "trazer"
            },

            new Verb("build")
            {
                past_tense = "built",
                past_participle = "built",
                traducao = "construir"
            },

            new Verb("burn")
            {
                past_tense = "burnt",
                past_participle = "burnt",
                traducao = "queimar"
            },

            new Verb("burst")
            {
                past_tense = "burst",
                past_participle = "burst",
                traducao = "interromper, explodir"
            },

            new Verb("buy")
            {
                past_tense = "bought",
                past_participle = "bought",
                traducao = "comprar"
            },

            new Verb("cast")
            {
                past_tense = "cast",
                past_participle = "cast",
                traducao = "lançar"
            },

            new Verb("catch")
            {
                past_tense = "caught",
                past_participle = "caught",
                traducao = "alcançar, pegar"
            },

            new Verb("choose")
            {
                past_tense = "chose",
                past_participle = "chosen",
                traducao = "escolher"
            },

            new Verb("cling")
            {
                past_tense = "clung",
                past_participle = "clung",
                traducao = "agarrar-se, apegar-se"
            },

            new Verb("come")
            {
                past_tense = "came",
                past_participle = "come",
                traducao = "vir, chegar"
            },

            new Verb("cost")
            {
                past_tense = "cost",
                past_participle = "cost",
                traducao = "custar"
            },

            new Verb("creep")
            {
                past_tense = "crept",
                past_participle = "crept",
                traducao = "arrastar-se, engatinhar"
            },

            new Verb("cut")
            {
                past_tense = "cut",
                past_participle = "cut",
                traducao = "cortar"
            },

            new Verb("deal")
            {
                past_tense = "dealt",
                past_participle = "dealt",
                traducao = "lidar, tratar, negociar"
            },

            new Verb("dig")
            {
                past_tense = "dug",
                past_participle = "dug",
                traducao = "cavar"
            },

            new Verb("do")
            {
                past_tense = "did",
                past_participle = "done",
                traducao = "fazer"
            },

            new Verb("draw")
            {
                past_tense = "drew",
                past_participle = "drawn",
                traducao = "desenhar"
            },

            new Verb("dream")
            {
                past_tense = "dreamed",
                past_participle = "dreamed",
                traducao = "sonhar"
            },

            new Verb("drink")
            {
                past_tense = "drank",
                past_participle = "drunk",
                traducao = "beber"
            },

            new Verb("drive")
            {
                past_tense = "drove",
                past_participle = "driven",
                traducao = "dirigir, impedir"
            },

            new Verb("dwell")
            {
                past_tense = "dwelt",
                past_participle = "dwelt",
                traducao = "habitar, residir"
            },

            new Verb("eat")
            {
                past_tense = "ate",
                past_participle = "eaten",
                traducao = "comer"
            },

            new Verb("fall")
            {
                past_tense = "fell",
                past_participle = "fallen",
                traducao = "cair"
            },

            new Verb("feed")
            {
                past_tense = "fed",
                past_participle = "fed",
                traducao = "alimentar"
            },

            new Verb("feel")
            {
                past_tense = "felt",
                past_participle = "felt",
                traducao = "sentir"
            },

            new Verb("fight")
            {
                past_tense = "fought",
                past_participle = "fought",
                traducao = "lutar"
            },

            new Verb("find")
            {
                past_tense = "found",
                past_participle = "found",
                traducao = "achar, encontrar"
            },

            new Verb("flee")
            {
                past_tense = "fled",
                past_participle = "fled",
                traducao = "fugir"
            },

            new Verb("fling")
            {
                past_tense = "flung",
                past_participle = "flung",
                traducao = "lançar, mover"
            },

            new Verb("fly")
            {
                past_tense = "flew",
                past_participle = "flown",
                traducao = "voar, viajar de avião"
            },

            new Verb("forbid")
            {
                past_tense = "forbade",
                past_participle = "forbidden",
                traducao = "proibir"
            },

            new Verb("forget")
            {
                past_tense = "forgot",
                past_participle = "forgotten",
                traducao = "esquecer"
            },

            new Verb("forgive")
            {
                past_tense = "forgave",
                past_participle = "forgiven",
                traducao = "perdoar"
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

            if(past == lista1_verbos[i].past_tense)
            {
                Resultado_Past.Text = "O Passado simples " + past + " está correto!";
            }
            else
            {
                Resultado_Past.Text = "O Passado simples " + past + " está incorreto!, o correto seria: " + lista1_verbos[i].past_tense;
            }

            if (participle == lista1_verbos[i].past_participle)
            {
                Resultado_Participle.Text = "O Particípio " + participle + " está correto!";
            }
            else
            {
                Resultado_Participle.Text = "O Particípio  " + participle + " está incorreto!, o correto seria: " + lista1_verbos[i].past_participle;
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

            int i = num.Next(0, 48);

            string msg = "Qual o passado simples e o participio do verbo to " + lista1_verbos[i].nome + "(" + lista1_verbos[i].traducao + ")?";

            Mensagem.Text = msg;
            Input_Participle.Text = "";
            Input_Past.Text = "";
            Resultado_Participle.Text = "";
            Resultado_Past.Text = "";
            Index_Verbo.Text = i.ToString();
        }

        private void btnTrocarParaLista2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Lista2());

            }catch(Exception ex)
            {
                DisplayAlert("ERRO", ex.Message, "OK");
            }
        }
    }

}
