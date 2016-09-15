using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using TicTacToeSignalR.Models;

namespace TicTacToeSignalR.Hubs
{
    public class MyHub : Hub
    {
        private string [] [] victoryСonditions = new string[] []
        {
            new []{"0;0", "0;1", "0;2"},
            new []{"1;0", "1;1", "1;2"},
            new []{"2;0", "2;1", "2;2"},
            new []{"0;0", "1;0", "2;0"},
            new []{"0;1", "1;1", "2;1"},
            new []{"0;2", "1;2", "2;2"},
            new []{"0;0", "1;1", "2;2"},
            new []{"2;0", "1;1", "0;2"},
        };

        private static List<Player> players = new List<Player>();
        private int count;

        public void Send(string x, string y)
        {
            Player player = players.Where(pl => pl.Id == Context.ConnectionId).ElementAt(0);
            if (player != null)
            {
                count++;
                Clients.All.setCheck(x, y);
                player.ruls.Add(x + ";" + y);
                Clients.AllExcept(player.Id).playerCanSetWay();
                checkConditions(player);
            }
        }

        private void checkConditions(Player player)
        {
            for (int i = 0; i < victoryСonditions.Length; i++)
            {
                checkCondition(victoryСonditions[i], player);
            }
        }

        private void checkCondition(string[] ruls, Player player)
        {
            for (int i = 0; i < ruls.Length; i++)
            {
                for (int k = 0; k < player.ruls.Count; k++)
                {
                    if (player.ruls[k].Equals(ruls[i])) player.Count ++;
                }
            }
            if (player.Count == 3 || count == 9)
            {
                player.Ex ++;
                Clients.All.endGame("Новая игра");
                refrashPlayersRuls();
                count = 0;
            }
            player.Count = 0;
        }

        private void refrashPlayersRuls()
        {
            foreach (Player player in players)
            {
                player.ruls.Clear();
            }
        }

        public void PlayerConnected()
        {
            players.Add(new Player { Id = Context.ConnectionId, Count = 0, ruls = new List<string>(), Ex = 0 });
            Clients.All.endGame("Подключен игрок. В сети: " + players.Count);
            count = 0;
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            Player player = players.Where(pl => pl.Id == Context.ConnectionId).ElementAt(0);
            if (player != null)
                players.Remove(player);
            return base.OnDisconnected(stopCalled);
        }
    }
}