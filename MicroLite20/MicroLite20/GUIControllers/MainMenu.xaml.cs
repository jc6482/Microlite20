﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MicroLite20.GUIControllers {
    public partial class MainMenu : ContentPage {

        public MainMenu() {
            InitializeComponent();

            showAllChars.Clicked += openShowAllChars;
            addCharButton.Clicked += openCreateCharacter;
            
        }

        async public void openShowAllChars(Object sender, EventArgs args) {
            await Navigation.PushAsync(new showAllCharacters());
        }

        async public void openCreateCharacter(Object sender, EventArgs args) {
            await Navigation.PushAsync(new createCharacter());
        }
    }
}
