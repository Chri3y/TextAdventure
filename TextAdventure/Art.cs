﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class Art
    {
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static string Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public static string MajorEvent01
        {
            get { return majorEvent01; }
            set { majorEvent01 = value; }
        }

        private static string majorEvent01 = @"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓█▓▓▓▓█████▒▓█▓█▓█▓▓██████▓█▓█▓█▓█▓█▓███████▓██▓▓███▓█▓▓██████▓█▓█▓█▓█▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓█▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓█
▓█▓▓▓▓▓▓▓██▓███▓▓██▓█████████████████▒███████████████████████████████████████████▓███████████████████▓███████████████████▓█▓████▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓██▓██
▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓██▓▓▓▓▓██████████▓██▓██▓████▓███████████▓██▓████████████▓▓▓█▓▓██▓█████▓█▓█▓█▓▓▓█▓█▓█▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓ ▓██▓▓██▓██▓▓███▓▓▓▓▓▓▓▓▓▓▓███████▓▓▓█▓███▓███▓██▓▓█▓▓▓▓▓▓█▓▓███▓▓▓█████▓█▓▓▓███████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▒▓████▓█████▓████▓▓███████████▓█▓███████▓███▓▓▓█▓█▓▓▓▓▓▓▓███▓███▓▓▓▓▓█▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓█▓███▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓██▓██▓█████▓████▓███████████████████████████████████████████████████████▓█████▓███▓█▓█▓▓▓▓▓█▓▓██▓█▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓█▓█▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓█▓▓██▓▓▓▓▓▓▓▓███▓▓▓  ░▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓████████████████████████████████████████▓███▓▓█▓▓▓▓▓▓█▓▓█▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓
▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█████▓▓▓▓▓▓▓▓▓▓█▓▓█▓  ▓███▓▓▓▓               ▓█▓▓▓▒▓▒ ░▒░░░░▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓█▓
▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒█▓▓██▓▒░▒▒▒░░░▒▒▒▒▓▒  ▒██▓█▓▓▓    ░░▒▒▓▓▒▒░  ▓█████▓▓             ████▓▓▓▓               ▒▓▓▓▓▓▓▓▒░ ▒▒▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓█▓▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒██▓██▓▓▓              ▓█▓███▓▓   ░▒▓▓▓▓▓▓▓▒░ ▓█▓███▓▓   ░░░░░░    ████▓▓▓▓               ▒██████▓ ░█████▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓█▓▓▓▓█▓█▓▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒█▓▓▓█▓██              ▓█▓███▓▓  ░▒▓▓▓▓▓▓▓▓▓▒ ▓█▓██▓▓▒ ░░▒▒▒▒▒▒░   █████▓▓                ▒███▓▓▓▓  ▓███▓▒▒▒▒▒▒▒▒▒░▒▓▓▓▓█▓▓▓▓▓▓█▓▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓█▓▓▓█▓▓▓              ▒█▓▓█▓▓▓  ░▒▓▓▓▓▓▓▓▓▓▒ ▓█▓██▓▓▒ ░▒▒▓▒▓▒▒▒░  ▓█▓█▓▓▓                ▒▓▓█▓▓▓▒             ▒▓▓▓██▓▓▓█▓▓▓▓▓▓▓▒▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▓▓              ▓████▓▓▒  ▒▒▓▓▓▒▓▒▓▒▓▒ ▓█▓█▓▓▓░ ▒▓▓▓▓▓▓▓▒▒  █▓██▓▓▓                ▒▓▓█▓▓█░          ░███████▓▓▓█▓▓▓▓▓▓█▓▒▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓██▓▓▓              ▒█▓██▓▓▒  ░▒▓▓▒▓▒▓▓▓▓▒ ▓████▓▓░░▓▓▓▓▓▓▓▒▒▒  ▓▓███▓▒                ▓███▓▓▓           ▒████▓▓▓▓▓▓▓▓▓▓▓███▓▒▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▒█▓▓██▓▓▓              ▒█▓██▓▓▒  ▒▒▓▓▓▒▓▓▓▓▓▒ ▓████▓▓░▒▓▓▓▒▒░░░▒░ ░█▓███▓▒                ▓██▓▓█▓           ▓█▓▓▓▓▓▓▓▓▓▓▓▓▓███▓▓▒▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓██▓▒▓              ▓█▓███▓▒ ░▒▒▒▓▒▓▓▓▓▓▒▒ ▓▓███▓▓ ░░░ ░▒▒▒▒▒▒ ▒█▓██▓▓▒                ▓▓██▓▓▓           ▓█▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓██
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓██▓▓▓              ▒▓▓███▓▒ ░▒▒▒▒▓▓▓▓▓▓▒░ ▓▓███▓▒   ░▒▒▒▒░░▒░ ░▓▓██▓▓▒ ░░             ▓▓██▓▓▒           ▓█▓▓▓▓▓▓▓▓█▓▓█▓▓▓█▓▓██
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓██▓▓▓              ▓█▓███▓░ ░▒▓▓▓▓▓▓▓▓▒▒░░▓▓███▓▓ ░░░         ▒▓▓██▓▓░ ░░            ░▓▓███▓            ██▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓█▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓█▓▓██▓▓▓              ▓▓▓██▓▓░ ▒▓▓▓▓▓▓▒▒▒▒▒ ▒▓████▓▓░     ░░▒▒   ▓█▓███▓  ░░            ▒▓▓█▓██           ░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▒▓▓▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓██▓▓▓              ▓█▓██▓▓░ ▒▒▓▒▒ ░░░▒▒▒ ▓▓▓███▓▓   ▒▒░   ▓▒  ▓█████▓  ░░            ▒▓██▓▓▓           ▒█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒▓▓▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▓▓              ▓▓▓██▓▓   ░░░░░░▒▒▒▒░ ▒▓████▓▒  ░▓▓░  ▒▒░░ ▓▓▓███▓   ░            ▒▓██▓▓▓           ▒█▓▓█▒▓▓▓▓████▓▓▓▓▓▒▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▓▓              ▓████▓▓░ ░▒▒▒▒░       ▓▓▓███▓▒ ▒▒▒▒▒▒░▒▒▒░ ▓▓███▓▓   ░            ▒▓██▓█▓           ▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓█▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▓▒              ▓▓▓█▓▓▓  ▒▒░   ░░ ░░  ▓▓▓███▓░ ▒▒░░░▒▒▒▓▒░ ▓███▓▓▓  ░░            ▓▓██▓▓▓           ▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓█▒▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▒▓              ▓█▓██▓▓░ ▒▒░  ▓▓   ░▒ ▓▓▓███▓░ ▒▒▒▒▒▒▒▒▒▒░ ▓▓██▓▓▓  ░░            ▓███▓▓▒           ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓█▓▒▒              ▓▓▓██▓▓  ▒▒░ ░▓▓▒░░░░ ▓▓▓███▓░░▒▒▓▓▓▓▒▒▒▒░ ▓███▓▓▒ ░              ▓██▓▓█░           ▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓█▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒▓              ▓█▓██▓▓  ▒▒▒░▒▒▓▒▒▒▒  ▓▓██▓█▓░░▒▒▒▒▓▓▓▓▓▒░░▓███▓▓░ ░             ░▓▓▓▓▓▓            ▓▓▒▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▒▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒▓              ▒▓▓██▓▓ ░▒▒▓▓▒▒▒▒▒▒▒░ ▓████▓▓ ▒▒▒▒▒▒▒▒▒▒▒ ░▓███▓▓░               ▒▓██▓█▓           ▒█▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▓              ▒▓▓███▒ ░▒▓▓▓▓▒▓▓▓▓▒░ ▓▓██▓▓▓ ▒▓▓▒▒▒▒▒▒▒░ ░▓████▓ ░░             ▓▓█▓█▓▓           ▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▒▓              ░▓▓█▓▓▓ ░▒▓▓▓▓▓▓▓▓▓▒░ ▓▓▓█▓▓▓ ▒▓▓▓▓▒▒▒▒░░ ▓▓▓▓██▓ ░░             ▓▓▓█▓▓▒           ▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▒▓▓▓▒▓              ▒▓▓█▓█▓  ▒▓▓▓▓▓▓▓▓▓▓░ ▓▓▓█▓▓▓░▒▓▓▓▒▒▒▒▒▒░ ▓▓▓███▓ ░▒             ▓▓█▓▓▓▒          ░█▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▓              ▒▓▓▓▓▓▓  ░▓▓▓▓▓▒▓▓▓▒░ ▓▓▓█▓▓▓░▒▒▒▒▒   ▒▒▒ ▓████▓▓ ▒▒            ░▓▓██▓▓           ▒▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓
▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓              ▒▓▓▓▓▓▓   ▒▓▓▓▓▓▒▓▓▒  ▓█▓█▓▓▓ ░▒▒▒░░░▒▒▒░ ▓▓▓█▓▓░ ▒▒            ░▓▓██▓▓           ▓▓▒▓▒▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▒▓▓▓▓
▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓              ▒▓█▓▓█▓     ▒▒▓▓▓▓▓▒  ▓▓▓▓▓▓▓  ░▒░▒▒▒▒▒▒▒ ▓▓██▓▓░ ▒░            ▒▓▓█▓▓▓           ▓▓▓▓▒▓▓▓▓█▓▓▓▓▓▓█▒▓▓▓▓▓▒▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓              ▒▓██▓▓▒      ░▒▓▓▓▒▒  ▓█▓▓▓▓▒ ░▒▒▒▒▓▓▒▒▒░░▓███▓▓░░▒░            ▓▓▓█▓▓▓          ░█▓▒▓▒▓▓▓▓█▓▓▓▓▓█▓▓▓▓▒▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓░             ▒▓▓█▓▓▒       ░▒▓▓▓▒ ░█▓▓▓▓▓▒░▒▓▓▓▒▒▒▒░   ▓▓█▓▓▓ ░▒▒            ▓▓█▓▓▓░          ▒█▒▒▒▒▓▓▒▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▓░             ░▓▓▓▓▓▒        ░▒▓▓▒ ▒▓▓▓▓▓▓▒▒▓▓▒▒░░     ▒▓██▓▓▒ ░▒▒            ▓▓█▓▓▓           ▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▒▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▓▒             ░▓█▓▓▓▒         ░▒▓▒ ▒███▓▓▓▒░░          ▒█▓█▓▓▒ ░░░░           ▓▓▓▓▓▓          ░▓▓▒▒▒▓▓▒▓█▓▓▓▓▓█▓▒▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▒▒             ▒▓▓▓▓▓░           ▒▒ ▓██▓▓▓▓░    ░░░▒▒▒░ ▒▓▓▓▓▓░ ░  ▒          ░▓▓▓▓▓▓          ▒▓▓▒▒▓▓▓▒▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒             ▓▓▓▓▓▓▒            ░ ▒█▓▓▓▓▓▒░▒▒▒▒▒▒▒▒░  ▓▓▓▓▓▓░░░  ░▒░        ░▓▓▓▓▓▒          ▓▓▓▒▒▓▓▒▓▓▓▓▓▓▓▓█▒▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒             ▓▓▓▓▓▓▒              ▒▓▓█▓▓▓▒▒▒▒▒▒░░░░   ▓▓█▓▓▒░     ▒▓▓░      ▓▓▓▓▓▓░         ░▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▒▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒  ▒▓▒░       ▓▓▓▓▓▓▒              ▓▓▓█▓▓▒░░▒▒▒▒▒░░░░  ▓▓▓▓▓▒   ░   ░▒▓▒     ▓▓▓▓▓▓░         ▒▓▒▓▒░▓▓▓▓▓▓▓▓▓▓█▓▒▓▒▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒ ▓█████▓███▓ ▓▓▓▓▓▓░              ▓█▓▓▓▒▒░░▒▒▒▒▒▓▒▒░ ░▓▓▓▓▓▒  ░      ▒▓░   ░▓▓▓▓▓▓          ▓▓▒▒░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▒▓▓▓▒▒▓█▓▓▓▓▓▓▓▓▓▓ ▓▓▓▓▓▓▒              ▓█▓▓▓▓▒░░▒▒▒▒▒▒▒░  ▒▓▓▓▓▓▒ ░ ░     ░▒░   ▒▓▓▓▓▓▓ ░░      ▒█▓▒▒▒▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓██▓▓▓▓▓▓▓▒▓▓ ▓▓▓▓▓▓░              ▓▓▓▓▓▓▒   ░░░░░    ▒▓▓▓▓▓░          ░  ░ ▓▓▓▓▓▓▒▓██████▓ ▓▓▓█▓▒▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒▓▓▓██▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓░░▒            ▓▓▓▓▓▓▒░           ▓▓▓▓▓▓░               ▓▓▓▓▓▓▒▓█▓▓▓███▓██▒▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓
▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒▓▓█▓▓▒▓▓▒▓▓▒▓▓███▓▒▓▓▓▒░█████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▒▓▓▓▒   ▒▓▓▓▓▓▓▓▓▓ ▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓█▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒▒▓▓▓▓▓▓▒▓████▓▓▓▓▓▒▒▓▓▓█▓▓▓▓▓█▓▓▓▓▒▓▓▓▒▒ ▓▓█▓▓▓▒▒▓▓▓▓▒▓▓▓▒▒▓▓█▓▓▓▓▓▓▓▓▓████▒▓▓▒▓▓▓█▒▓▓▓▓▓▓▓▓▓██▓▒▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▒▓▒▓
▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▒█████▓▓▓█▓▓▒▒▒▒▒▒▒▒▒▒▒▒░▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▒▓▓▓▒▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓███▓▓▓▓▓▓▓▓▓▒▓██▓▓▓▓█▓▓▓███▓▓▒▓▓▓▒▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓██▓▓▓███▓▓██▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▒▒▒▒▒▒▒▓▓▓███▓▓▓▒▒▒▓▓▓▓▓▓▓▓▓▓██▓█▓░ ░░░▒░▒░▒▒▒▒▒▒▓▓██████▓▓▓▓▓▓▓▓▓▓▒██▓▒▒▓▓▓▓▓██▓▒▒▒▒▓▓▓▓▓▓▓▓▓
▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒██▓▒▓▓▓▓▓▓▓▓█▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓█▓██▓▓█▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█████▓▓▓▓▓▓▓▓▓▓▓▓█▓▒▓▓▓▓▓▓██▓▒▒▓▒▒▓▓▓▒▒▒▓▓
▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▒▒▒▒▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▓▒▓▓▒▒▓▒▒▓▓▒▓
▓▓▒▒▓▒▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▒▓▓▓▓▒░░▒▓▓▒▒▒▒▒▒▒▒▒▓▓▒▓▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▓█▓▒▓▓▓▓▓▓▓▓▓▓▒▓▒▓▓▓▓▓██▓▒▒▓▒▒▓▓▓▓▓▓▒▓▓
▒▓▒▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▒██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▒▒▒▓▓▓▓▓▓██▓░▒▓▓▒▒▒▓▒▓▓▒▒▓
▒▒▒▓▓▒▓▒▒▒▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▓▓▓▓▓▓▓▓▓▒▒▓▒▓▓▓▓▓███▒▒▒▓▓▓▒▒▒▒▓▓▒▒▒
▒▓▓▓▒▓▓▓▓▓▒▓▓▓▒▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒██▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓█▓▒▓▓▓▓▓▓▒▓▓▒▓▓▒▓▓▓▓▓██▓░▒▒▒▒▒▓▓▒▒▓▒▓▒▒
";



        private static string logo = @"    
                                                                       
  ░▒▒▒▒▒     ░▒▒▒▒    ▒▒▒░  ▒▒▒░   ░▒▓▒▒    ▒▒   ▒▒    ▒▒▒▒░   ░▒░     ▒▒  
  ███████▓  ███████░  █████████▓  ███████░ ░██░ ▒██  ▒███████  ███    ▓██  
  ▓██  ███  ██▒  ██▒  ██ ░██ ██▓  ██░  ██▒ ░██  ▒██  ▓██  ▓██  ██▓    ▒██  
  ▓██  ██▓  ██▓  ██▒  ██ ▒██ ██▓  ██▒  ██░  ██  ▒██  ▒██  ▓██  ██▓    ▒██  
  ▓██  ██▓  ██▓  ██▒  ██ ▒██ ██▓  ██▒  ██░ ░██  ▒██  ▓██  ▓██  ██▓    ▒██  
  ▓██  ██▓  ██▓  ██▒  ██ ▒██ ██▓  ██▒  ██░  ██  ░██  ▒██  ▓██  ██▓    ▒██  
  ▓██  ██▓  ██▒  ██▒  ██ ▒██ ██▓  ██▒      ░██  ░██  ▓██  ▓██  ██▓    ▒██  
  ▓██████▒  ███████▒  ██ ░██ ██▓  ██████▓   ███████  ▒███████  ██▓ ██ ▒██  
  ▓██  ██▓  ██▓  ██▒  ██ ▒██ ██▓      ░██▒ ░██░ ▒██  ▓██  ▓██  ██▓ ██ ░██  
  ▓██  ██▓  ██▒  ██▒  ██ ▒██ ██▓  ██   ██▒  ██  ░██  ▓██  ▓██  ██▒ ██ ░██  
  ███  ███  ██▓  ██▒  ██ ▒██ ██▓  ███████░ ░██  ▒██  ▓██  ▓██  ██████████  
  ░▒░  ▒▒   ▒▒   ░▒   ▒▒  ▒░ ▒▒     ▒▒▒▒    ▒▒   ▒▒   ▒░   ░░  ▒▒▒░  ░▒░▒  
  ▒██   ▓██   ████▓███   ██▓    ████▓▒    ██▓  ▒██   ▓███████▓    ▓███▓▒   
  ███   ███  ▒████████░  ███   ████████   ███  ▒██▒  █████████  ░████████  
  ▓██   ███  ░██▒    ░   ███  ▒██▒  ███   ███  ▒██▒     ███     ▒██▒  ███  
  ▓██   ███  ░██▒        ███  ▒██▒  ███   ███  ▒██▒     ███     ▒██░  ███  
  ▓██   ███  ░██▒        ███  ▒██▒   ░░   ███  ▒██▒     ███     ▒██▒  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██░  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██▒  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██░  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██▒  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██▒  ███  
  ▓██   ███  ░██▒        ███  ▒██▒        ███  ▒██▒     ███     ▒██░       
  ▓██   ███  ░██▒        ███  ▒██▒        ██▓  ░██▒     ███     ▒██░       
  ▓████████  ░████████   ███  ▒██▒  ▓█    ████████▒     ███     ▒██████▓   
  ▓████████  ░████████░  ███  ▒██▒  ███   ████████▒     ███      ████████  
  ▓██░  ███  ░██▒    ░   ███  ▒██▒  ███   ███  ▒██▒     ███           ███  
  ▓██   ███  ░██▒        ███  ▒██▒  ███   ██▓  ░██▒     ███           ███  
  ▓██   ███  ░██▒        ███  ▒██▒  ▓██   ███  ▒██▒     ███     ▒██░  ███  
  ▓██   ███  ░██▒        ███  ▒██░  ▓██   ███  ▒██▒     ███     ▓██░  ███  
  ▓██   ███  ▒████████   ███  ░████████   ███  ▒██▒     ███     ▒████████  
  ███░  ███  ▒████████░  ███   ▓███████   ███  ▒██▒     ███      ███████▒  ";



        private static string title = @"▓██████▓ █████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
████████ ████████████████████████████████████████████████████████████████████████████████████████▓▒ ▓█████████████████████████████████████████████████
███████▓ █████▓▓▒▓███▓▒▒▓██▓▓▓█▓▓▓██▓▒▒▓██▓▓██▓███▓▒▓███▓████▓█████████████████████████████▓▒░        ░▓▓█████████████████████████████████████████████
███████▓ ▓███▒     █░    ▒█       █░    ▒█  █  ▓█     █  ▓██  ▓███████████████████████▓▒░   ░░▒▒▒▒   ▒▒ ░ ░░▒▓████████████████████████████████████████
███████▓ ████▒ ▒█  █  ██ ░█  ▓ █  █  ██ ░█  █░ ██ ░█  █░ ▓██  ▓██████████████████▓▒░░░░▒▒▒▒▓▒▓▒▒▓▓▒▒▒▓▓▒▓▒▒▒░░░░░▒▓▓██████████████████████████████████
███████▓ ▓███▒ ▒█  █  █▓ ▒█  ▓ ▓  █  ██ ░█  █░ ██ ░█  █░ ▓██░ ▓█████████████▒     ░░░▒▒░▒░▒▒░▒▒░▒░▒▒▒░▒░▒░░░░░░░░      ░██████████████████████████████
███████▓ ▓███▓ ▒█  █  ██ ▒█  ▓ ▓  █  ██░▓█  █▒ ██ ░█  █▒ ▓██░ ▓█████████████                                            ██████████████████████████████
███████▓ ▓███▒     █     ▒█  ▓ ▓  █▒    ██     ██     █░ ▓ ▒▒ ▓█████████████                                           ░██████████████████████████████
███████▓ ▓███▓ ░█  █  █▓ ▒█  ▓ ▓  ██▓█▓  █  █░ ██  █  █░ █  ▓ ▓█████████████▓▒▓▓▓▓▓▓▓▓▓▒           ░       ░▓▓▓▓▓▓▓▓▓▓▓███████████████████████████████
███████▓ ▓███▒ ▒█  █  ██ ▒█  ▓ ▓  █▒ ░  ▒█  █▒ ██ ▒█  █░      ▓█████████████████████████░ ░░░░ ▒▒▒▒▒░░▒░░░░▒██████████████████████████████████████████
███████▓ ▓████ ▓█▒░██▒▓▓░▒▓▒█▓░█▓██▓▒░▓██▓░▓█▒░██░▒█▒░██▓▒▓▓░▓██████████████████████████░ ░░░░ ▒░▒▒▒░░▒░░░ ▒██████████████████████████████████████████
███████▓ ▓███▒  █▒  █░     ▒█  ▓█░     ██  █▓  █▒      █▓     █████████████████████████▓░ ░░▒░ ░░▒▒▒░░▒ ░░░▒██████████████████████████████████████████
███████▓ ▓███▓  █▒  █░ ░██▓██  ██  ██  ██  █▓  ███░  ███  ▒█  ▓████████████████▓░█▓▓▓▓▓▓▒░░░░▒░░░░░░░░▒░░░░▒▓▒▓▓▓█▓░██████████████████████████████████
███████▓ ▓███▓  █▒  █░ ▒█████  ██  ██  ██  ██  ███▒ ░███  ▓█  ▓████████████████▓ █████▓▓▒ ░░░░░░░░░░░░▒░░░░▒▓▒████▓ ██████████████████████████████████
███████▓ ▓███▓  █▒  █░ ▒█████  ██  ██████  █▓  ███▒  ███  ▒█  ▓█████████████████░█▓██▓▓▓▒░░░░▒░░░░░░░░▒░░░░▒▓▒████▓░██████████████████████████████████
███████▓ ▓███▓  █▒  █░ ░█████  ██  ██████  █▓  ███▒  ███  ▒█  ▓█████████████████  ░░░  ░░░░░░░░░░░░░░░░░░░░░        ██████████████████████████████████
███████▓ ▓███▓  █▒ ░█░ ▒█████  ██  ██████  ██  ███▒  ███  ▒█  ▒█████████████████                                    ██████████████████████████████████
███████▓ ▓███▓  █▒  █░ ▒█████  ██  ██████  ██  ███▒  ███  ▓█▒ ███████████████████▒ ▓███▒                    ▓███▒░▓███████████████████████████████████
███████▓ ▓███▓  █▒ ░█░ ▒█████  ██  ██████  █▓  ███▒  ███  ▒████████████████████████▒▒██▓                    ███▒▓█████████████████████████████████████
███████▓ ▓███▓     ░█░     ▒█  ██  ██  ██      ███▒  ███▒     ██████████████████████▓░▓▒  ░░░░░ ░  ░░ ░ ░░  ▓▓▒███████████████████████████████████████
███████▓ ▓███▓  ▓░ ░█░  ▒▒░██  ██  ██  ██  ▓▒  ███▒  █████▓▓  ▓███████████████████████░  ░░░░░░░░  ░░░░░░░   ▓████████████████████████████████████████
███████▓ ▓███▓  █▓  █░ ▒█████  ██  ██  ██  ██  ███▒  ███▓▓██  ▓████████████████████████▓ ░░░░░░░░░░░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓███▓  █▒  █░ ▒█████  ██  ██  ██  █▓  ███▒  ███  ▒█  ▓████████████████████████▓ ░░░░░░░░▒░░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓███▒  █░  █      ▒█  ▓█      ██  █▓  ███░  ███░     █████████████████████████▓ ░░░░░░░░░░░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓███▓ ▒█▓ ▓█▓░░░░ ▓█▒ ███▒░░░░██ ░██ ▒███▓ ▓████▒░░░▓█████████████████████████▓ ░░░░░░░░░░░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓█████████████████████████████████████████████████████████████████████████████▓ ░▒░░░░░░░▒░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓█████████████████████████████████████████████████████████████████████████████▓ ░░▒░▒░░░░░░░░░░░░░ ██████████████████████████████████████████
███████▓ ▓██████████████████████████████████████████▓ ▒████████████████████████████████▓ ░░░▒░░░▒░▒░░░▒░░░░ ██████████████████████████████████████████
█████▓█▓ ▓███████████████████▓▓████████████████████▓░ ▒████████████████████████████████▓ ░░░░░░▒░░░░░░░░░░░ ██████████████████████████████████████████
█████▓█▓ ▓███████████████████▓▓████████████████████▓░ ▒████████████████████████████████▓ ░░░▒░░░░░░░░░░░░░░ ██████████████████████████████████████████
▓█▓▓▓▓█▓ ▒█▓▓▓▓▓▓▓▓█▓█▓▓▓▓▓██▓▓███████▓█▓█▓▓▓█▓█▓██▓░ ░▓▓▓████████████▓██████▓█▓▓██████▓ ▒░▒▒░▒▒░▒░▒▒░▒▒▒▒░░▓███▓██▓█▓██▓█▓█▓▓█▓██▓█▓█▓▓███▓▒▒▒▒▒▓████
▓██▓█▒█▓ ▒█▓▓█▓██▓██▓█▓▓█▓██▓▓▓███▓▓█▓▓█▓█▓██▓██▓██▓▒ ░▓▓▓▓██████▓█▓█▓██▓█▓█▓▓███████▓█▓ ░░░▒░▒░░░░░▒░░░░░░ ▓███▓██████▓█▓██▓█▓▓█▓█▓██▓███▒ ▒▒▒░░ ▒███
▒██▓█▓▓▓ ▒█▓██▒██▓█▒▓█▒██▓██▓█▓▓██▓█▓▓█▓▓█▓█▓▒█▓▓██▓▒ ▒▓▓▓▒▓▓▓██▓█▓██▓█▒▓█▓██▓█▓▓█▓██▓█▓ ▒░░░░░░░░░▒░▒░░░░░░▒█████▓█▓██▓█▓▒█▓█▓██▓█▓██▓█▓  ▒█▓▒░░░  ▒█
███▓█▓█▓ ▒███████▓░▓██████████▓████████████▓▒██████▓▒ ▒█▓█▓▓▓▒████████▓▒█████████████▓█▓ ▒▒░▒░▒░ ▒▒░▒░▒▒░▒░ ▓████████████▒▒████████████▒░ ░▒▒░▓░░  ▓██
▒▓▓▓▓▓▓▓ ▒█▓▓▓▓▓▓░▒█▓▓▓▓▓▓▓▓▓▓▒▓▓▓▓▓▓▓▓▓▓█▒░▓▓▓▓▓▓▓▓▒ ░▓▓▓▒▒▒▒▒▒▓▓▓▓▓▒░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ░░░▒░░░░▒░░░░░░░░░ ▒▓▓▒▓▓▒▓▒▓▓▓▒ ▓▓▒▓▒▒▓▒▓▒▓▓░   ░░░░▒░ ▒████
░░        ░░░ ░░░ ░░░░░░░░░ ░░░▒░░░░░░░░░░  ▒░░░░░▒░░ ░▒▒▒▒▒▒░░░░▒▒▒▓ ░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒ ░░░░░  ░░░░░░░░░░░ ▒▓▒▒▒▒▒▒▓▒▒▓ ░▓▒▒▒▒▒▒▒▒▓░  ░ ░░░░░░  █████
▓█▓▓▓▓ ░ ▒▓▓▒▒▓▓▒ ▒▓▓▒▒▓▓▒▓▒▓▓  ▓▓▓▓▒▓▒▒▓▓░ ▓▓▓▓▒▓▓░░░   ▒▓█▓▓▓▒▒▒▓██ ░██▓█▓█▓█████████▓ ▒░▒▒▒ ░▒░░░░░░░░░░ ▓█▓██▓██▓███░▒███▓████▓▒ ░░░░▒▒░░░░  █████
▓▓█▓▓▓ ░ ░█▓▓▓▓▓▓ ▓▓▓▓▓▓▓▓▓▓▓█  █▓▓▓▓▓█▒▓█░ ▓▓█▓▓▓▒▓░ ░    ▒▓█▒▓▒▒▒▒█░▒█▓█▓▓█▓▓█▓▓█▓▓██▒░░░░░▒  ▒░░░░░░░░░░ ▒█▓▓▓▓▓▓▓▓██ ░█▓█▓██▓▒  ░░░░░░░░  ░  █████
  ░▒▒▓ ░ ▒█▒▓▓▒█▓ ▓▓▒▓▓▒▓▓▒█▓▓  ▓▒▒▓▓▒▓▓▒█░ ▓▓█▓░▒▓▓░ ░      ▓▓▓▒▒▒▒▓ ▒██▓▓█▓█▓▓█▓▓█▓▓▓░░▒░░░▒  ░▒░░▒░░▒░░░░▒██▓▓█▒██▒▓█░░█▓▓█▓▒░    ▒░░░  ░░░░░ ▓████
         ▒█▒▓▓▒▓▓ ▓▓▒▓▓▒▓▓▒▓▓▓░ ▒░▓▓▓▒▓▓▒█▒ █▒▒▒▒█▓▒░ ░ ░  ░    ▒▒▓▒▒ ░▓█▓▓█▓█▓▓█▓▓█▓░░░░░░░░░░ ░▒░░▒░░░░░░ ▒██▓▓▓▓▓▓▓██ ░█▓█▓░   ░░░░░░░░░  ░░  ▓████
░░       ▒▒▒▒▓▓▓▓ ▒▓▒▓▒▓▒▒▓▓▒▓░ ▒░▒▓▒▒▓▒▒▓░ ▒░▒▒▒▓▓▓░░░  ░ ░      ▒▒▒  ▒█▓▓▓▓▓▒▓▓▒▓▓▒░░▓░░░░░▒  ▒▒░░░░░░░░░ ▒█▓▓▓▓▓▓▓▓▓▓ ░█▒░  ░░░░░▒░░░ ░░░░░   ▓████
░░░░░░  ░     ░▒▒ ░▓▒▒▒▒▒▒▒▒▒▒░ ▒░▒▒░░▒▒▒▒  ▒▒▒▒▒▒▒░ ░░      ░░    ░▒   ░▒▒▒▒▒▒▒▒▒▒ ░▒░ ░░░░░░    ░▒░░░░░░░ ▓▓▓▓▓▓▓▓▓▓▓█░░▓   ░░░░░ ░░░░░░▒░░░░  ▓████
 ░       ░    ░▒▓  ▒▒▒▒▒▒▒▒▒░▓░ ░░▒▒░░▒▒▒▒  ▒▒ ▒▒▒▒░  ░             ░   ░▓▒▒▒▒▒▒▒▓▒░░▒░ ░░░░░░     ░░░░░░░  ▒▓█▓▓▓▓▓▓███░    ░▒░ ░ ░░░░░░░░░░ ░░ ▒████
 ░░░░░  ░░░░░ ▒▓▓  ▒▒▒▒▒▒▒▒▒▒▒▒ ░░▒▒▒░▒░░▒░ ▓▒░▒▒▒▒▒░░░                 ░▒▓░░▓▒▓▒▒▒▓▒░  ░▒░░▒░    ░░░░▒░░░░ ▓█▓▓█▓▓█▓█▒   ░░░ ▒░ ░  ░ ░░  ░ ░    ▒████
░░      ░   ░░▒▓▓  ▒▓▒▓▒▒▒▒▓▒▒▓ ░░▒▓▒░▒▒▒▓░ ▓▒▒▒▒▓▒▒ ░                   ▒▓░ ░▒▒▒░▒▒▒▒ ░░░░░░▒  ░░░░░░░░░░░ ▓█▒▓█▓▓█▒▒ ░  ░░░░ ░░░░░ ░░  ░░  ░   ▒████
░░   ░  ░ ░ ░ ░▒▒  ░▒░░░░░░▒░ ░   ▒▒░ ▒░░░░ ▒░░▒░▒▒ ░░                   ▒▒   ░ ░░░ ░░  ░░░ ░░  ░░░░░░░░░░░ ░▒▒▒▒▒▒░░░░░░ ░░░░▒▒░░░░░   ░░░░░░░  ▒████
 ░   ░   ░ ░  ░░░  ░░░░░░░ ▒▒     ░ ░░░░     ░ ░░░░  ░░                  ░░ ░    ░  ░░  ░░░░░░  ░░░░░░░░░░░░ ▒▒▒▒░ ░░░░░  ░▒░░▒░ ░░░░░░░░▒░░░░░░ ▒████
░         ░   ▒▒░  ▒▒ ▒▒▒░ ▒▒ ░ ░░░ ░░▒ ░░░ ░▒ ░░ ░ ░░░                  ░░░░ ░ ░░ ░▒▒  ░░░░░░░ ░░░░░░░░░░░░ ▒▓▒  ░░  ░░  ░░    ░░░░░░░ ░░░      ░████
               ░ ░ ░░                          ░    ░░                    ░  ░   ░  ░░  ░ ░░ ░    ░░ ░ ░ ░ ░ ░     ░░░ ░  ░░  ░░ ░ ░░   ░        ░████
     ░▒░        ░  ░░ ░ ░   ░                     ░  ░░                   ░         ▒░  ▒░░░░░  ░░░░░░░░░░░  ░  ░░ ░░░ ░░ ▒░░░▒░░░░ ░░   ░░  ░░  ░████
░  ░ ░   ░░  ░░  ░ ░░░░  ░ ░░░   ░   ░  ░    ░   ░░  ▒░ ░                 ░░ ░   ░ ░▒░ ░░░░▒░░  ░░░▒░░░░░░░░ ░░ ░░ ░░░░▒  ░░ ░░░░░░░ ░░░░░░░░░░  ░█░ ░";
    }
}
