using Nerdcast.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerdcast.Maps
{
    class JNMaps : Utils
    {
        public string btnNerdcast = "//nav[2]//a[text()='NerdCast']";
        public string pesquisaNerdcast = "//input[@placeholder='Pesquisar NerdCast...']";
        public string nerdCast = "//a[text()='NerdCast 251']";
        public string btnPlay = "//button[@data-podcast-name='Especial RPG – O Bruxo, a Princesa e o Dragão']";
        public string btnPause = "//i[@class='icon-pause']";
        public string TimerNerdcast = "//span[@id='podcastCurrentTimeText']";
    }
}
