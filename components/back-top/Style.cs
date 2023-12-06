using System;
using CssInCSharp;
using static AntDesign.GlobalStyle;
using static AntDesign.Theme;
using static AntDesign.StyleUtil;

namespace AntDesign
{
    public partial class BackTopToken : TokenWithCommonCls
    {
        public int ZIndexPopup
        {
            get => (int)_tokens["zIndexPopup"];
            set => _tokens["zIndexPopup"] = value;
        }

    }

    public partial class BackTopToken
    {
        public string BackTopBackground
        {
            get => (string)_tokens["backTopBackground"];
            set => _tokens["backTopBackground"] = value;
        }

        public string BackTopColor
        {
            get => (string)_tokens["backTopColor"];
            set => _tokens["backTopColor"] = value;
        }

        public string BackTopHoverBackground
        {
            get => (string)_tokens["backTopHoverBackground"];
            set => _tokens["backTopHoverBackground"] = value;
        }

        public int BackTopFontSize
        {
            get => (int)_tokens["backTopFontSize"];
            set => _tokens["backTopFontSize"] = value;
        }

        public int BackTopSize
        {
            get => (int)_tokens["backTopSize"];
            set => _tokens["backTopSize"] = value;
        }

        public int BackTopBlockEnd
        {
            get => (int)_tokens["backTopBlockEnd"];
            set => _tokens["backTopBlockEnd"] = value;
        }

        public int BackTopInlineEnd
        {
            get => (int)_tokens["backTopInlineEnd"];
            set => _tokens["backTopInlineEnd"] = value;
        }

        public int BackTopInlineEndMD
        {
            get => (int)_tokens["backTopInlineEndMD"];
            set => _tokens["backTopInlineEndMD"] = value;
        }

        public int BackTopInlineEndXS
        {
            get => (int)_tokens["backTopInlineEndXS"];
            set => _tokens["backTopInlineEndXS"] = value;
        }

    }

    public partial class BackTop
    {
        public CSSObject GenSharedBackTopStyle(BackTopToken token)
        {
            var componentCls = token.ComponentCls;
            var backTopFontSize = token.BackTopFontSize;
            var backTopSize = token.BackTopSize;
            var zIndexPopup = token.ZIndexPopup;
            return new CSSObject()
            {
                [componentCls] = new CSSObject()
                {
                    ["..."] = ResetComponent(token),
                    Position = "fixed",
                    InsetInlineEnd = token.BackTopInlineEnd,
                    InsetBlockEnd = token.BackTopBlockEnd,
                    ZIndex = zIndexPopup,
                    Width = 40,
                    Height = 40,
                    Cursor = "pointer",
                    ["&:empty"] = new CSSObject()
                    {
                        Display = "none",
                    },
                    [$"{componentCls}-content"] = new CSSObject()
                    {
                        Width = backTopSize,
                        Height = backTopSize,
                        Overflow = "hidden",
                        Color = token.BackTopColor,
                        TextAlign = "center",
                        BackgroundColor = token.BackTopBackground,
                        BorderRadius = backTopSize,
                        Transition = @$"all {token.MotionDurationMid}",
                        ["&:hover"] = new CSSObject()
                        {
                            BackgroundColor = token.BackTopHoverBackground,
                            Transition = @$"all {token.MotionDurationMid}",
                        },
                    },
                    [$"{componentCls}-icon"] = new CSSObject()
                    {
                        FontSize = backTopFontSize,
                        LineHeight = @$"{backTopSize}px",
                    },
                },
            };
        }

        public CSSObject GenMediaBackTopStyle(BackTopToken token)
        {
            var componentCls = token.ComponentCls;
            return new CSSObject()
            {
                [$"@media (max-width: {token.ScreenMD}px)"] = new CSSObject()
                {
                    [componentCls] = new CSSObject()
                    {
                        InsetInlineEnd = token.BackTopInlineEndMD,
                    },
                },
                [$"@media (max-width: {token.ScreenXS}px)"] = new CSSObject()
                {
                    [componentCls] = new CSSObject()
                    {
                        InsetInlineEnd = token.BackTopInlineEndXS,
                    },
                },
            };
        }

        protected override UseComponentStyleResult UseComponentStyle()
        {
            return GenComponentStyleHook(
                "BackTop",
                (token) =>
                {
                    var fontSizeHeading3 = token.FontSizeHeading3;
                    var colorTextDescription = token.ColorTextDescription;
                    var colorTextLightSolid = token.ColorTextLightSolid;
                    var colorText = token.ColorText;
                    var controlHeightLG = token.ControlHeightLG;
                    var backTopToken = MergeToken(
                        token,
                        new BackTopToken()
                        {
                            BackTopBackground = colorTextDescription,
                            BackTopColor = colorTextLightSolid,
                            BackTopHoverBackground = colorText,
                            BackTopFontSize = fontSizeHeading3,
                            BackTopSize = controlHeightLG,
                            BackTopBlockEnd = (int)(controlHeightLG * 1.25),
                            BackTopInlineEnd = (int)(controlHeightLG * 2.5),
                            BackTopInlineEndMD = (int)(controlHeightLG * 1.5),
                            BackTopInlineEndXS = (int)(controlHeightLG * 0.5),
                        });
                    return new CSSInterpolation[]
                    {
                        GenSharedBackTopStyle(backTopToken),
                        GenMediaBackTopStyle(backTopToken)
                    };
                },
                (token) =>
                {
                    return new BackTopToken()
                    {
                        ZIndexPopup = token.ZIndexBase + 10,
                    };
                });
        }

    }

}