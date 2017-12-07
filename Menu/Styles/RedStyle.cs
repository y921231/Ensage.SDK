﻿// <copyright file="DefaultMenuStyle.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Menu.Styles
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.Renderer;

    using Newtonsoft.Json;

    using SharpDX;

    using Color = System.Drawing.Color;

    [Export]
    [Export(typeof(IMenuStyle))]
    public class RedStyle : IMenuStyle
    {
        [ImportingConstructor]
        public RedStyle([Import] IRendererManager renderer)
        {
            renderer.TextureManager.LoadFromResource(Menu, @"MenuStyle.darkred.menubg1.png");
            renderer.TextureManager.LoadFromResource(Item, @"MenuStyle.darkred.itembg1.png");
            renderer.TextureManager.LoadFromResource(ArrowLeft, @"MenuStyle.darkred.arrowleft.png");
            renderer.TextureManager.LoadFromResource(ArrowLeftHover, @"MenuStyle.darkred.arrowlefthover.png");
            renderer.TextureManager.LoadFromResource(ArrowRight, @"MenuStyle.darkred.arrowright.png");
            renderer.TextureManager.LoadFromResource(ArrowRightHover, @"MenuStyle.darkred.arrowrighthover.png");
            renderer.TextureManager.LoadFromResource(Checked, @"MenuStyle.darkred.circleshadow.png");
            renderer.TextureManager.LoadFromResource(Unchecked, @"MenuStyle.darkred.circleshadowgray.png");
            renderer.TextureManager.LoadFromResource(Slider, @"MenuStyle.darkred.sliderbgon.png");
            
            StyleConfig.ArrowSize = new Vector2(20, 20);
            StyleConfig.TextSpacing = 5;
            StyleConfig.LineWidth = 3;
            StyleConfig.LineColor = Color.Black;
            StyleConfig.SelectedLineColor = Color.DarkRed;
            StyleConfig.Border.Color = Color.Transparent;
            StyleConfig.Border.Thickness = new Vector4(5, 7, 1, 7);
            StyleConfig.Font.Color = Color.White;
            StyleConfig.Font.Family = "Calibri";
            StyleConfig.Font.Size = 16;
        }

        public StyleConfig StyleConfig { get; } = new StyleConfig();

        public string ArrowLeft { get; } = "menuStyle/darkred/left";

        public string ArrowLeftHover { get; } = "menuStyle/darkred/leftHover";

        public string ArrowRight { get; } = "menuStyle/darkred/right";

        public string ArrowRightHover { get; } = "menuStyle/darkred/rightHover";

        public string Checked { get; } = "menuStyle/darkred/checked";

        public string Item { get; } = "menuStyle/darkred/item";

        public string Menu { get; } = "menuStyle/darkred/menu";

        public string Name { get; } = "Dark Red";

        public string Slider { get; } = "menuStyle/darkred/slider";

        public string Unchecked { get; } = "menuStyle/darkred/unchecked";

        public override string ToString()
        {
            return Name;
        }
    }
}