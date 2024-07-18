namespace AntDesign.Themes
{
    public class Default
    {
        private static readonly GlobalToken _token = new GlobalToken()
        {
            ["blue"] = "#1677ff",
            ["purple"] = "#722ED1",
            ["cyan"] = "#13C2C2",
            ["green"] = "#52C41A",
            ["magenta"] = "#EB2F96",
            ["pink"] = "#eb2f96",
            ["red"] = "#F5222D",
            ["orange"] = "#FA8C16",
            ["yellow"] = "#FADB14",
            ["volcano"] = "#FA541C",
            ["geekblue"] = "#2F54EB",
            ["gold"] = "#FAAD14",
            ["lime"] = "#A0D911",
            ["colorPrimary"] = "#1677ff",
            ["colorSuccess"] = "#52c41a",
            ["colorWarning"] = "#faad14",
            ["colorError"] = "#ff4d4f",
            ["colorInfo"] = "#1677ff",
            ["colorLink"] = "#1677ff",
            ["colorTextBase"] = "#000",
            ["colorBgBase"] = "#fff",
            ["fontFamily"] = "-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial,\n'Noto Sans', sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol',\n'Noto Color Emoji'",
            ["fontFamilyCode"] = "'SFMono-Regular', Consolas, 'Liberation Mono', Menlo, Courier, monospace",
            ["fontSize"] = 14d,
            ["lineWidth"] = 1d,
            ["lineType"] = "solid",
            ["motionUnit"] = 0.1d,
            ["motionBase"] = 0d,
            ["motionEaseOutCirc"] = "cubic-bezier(0.08, 0.82, 0.17, 1)",
            ["motionEaseInOutCirc"] = "cubic-bezier(0.78, 0.14, 0.15, 0.86)",
            ["motionEaseOut"] = "cubic-bezier(0.215, 0.61, 0.355, 1)",
            ["motionEaseInOut"] = "cubic-bezier(0.645, 0.045, 0.355, 1)",
            ["motionEaseOutBack"] = "cubic-bezier(0.12, 0.4, 0.29, 1.46)",
            ["motionEaseInBack"] = "cubic-bezier(0.71, -0.46, 0.88, 0.6)",
            ["motionEaseInQuint"] = "cubic-bezier(0.755, 0.05, 0.855, 0.06)",
            ["motionEaseOutQuint"] = "cubic-bezier(0.23, 1, 0.32, 1)",
            ["borderRadius"] = 6d,
            ["sizeUnit"] = 4d,
            ["sizeStep"] = 4d,
            ["sizePopupArrow"] = 16d,
            ["controlHeight"] = 32d,
            ["zIndexBase"] = 0d,
            ["zIndexPopupBase"] = 1000d,
            ["opacityImage"] = 1d,
            ["wireframe"] = false,
            ["motion"] = true,
            ["blue-1"] = "#e6f4ff",
            ["blue1"] = "#e6f4ff",
            ["blue-2"] = "#bae0ff",
            ["blue2"] = "#bae0ff",
            ["blue-3"] = "#91caff",
            ["blue3"] = "#91caff",
            ["blue-4"] = "#69b1ff",
            ["blue4"] = "#69b1ff",
            ["blue-5"] = "#4096ff",
            ["blue5"] = "#4096ff",
            ["blue-6"] = "#1677ff",
            ["blue6"] = "#1677ff",
            ["blue-7"] = "#0958d9",
            ["blue7"] = "#0958d9",
            ["blue-8"] = "#003eb3",
            ["blue8"] = "#003eb3",
            ["blue-9"] = "#002c8c",
            ["blue9"] = "#002c8c",
            ["blue-10"] = "#001d66",
            ["blue10"] = "#001d66",
            ["purple-1"] = "#f9f0ff",
            ["purple1"] = "#f9f0ff",
            ["purple-2"] = "#efdbff",
            ["purple2"] = "#efdbff",
            ["purple-3"] = "#d3adf7",
            ["purple3"] = "#d3adf7",
            ["purple-4"] = "#b37feb",
            ["purple4"] = "#b37feb",
            ["purple-5"] = "#9254de",
            ["purple5"] = "#9254de",
            ["purple-6"] = "#722ed1",
            ["purple6"] = "#722ed1",
            ["purple-7"] = "#531dab",
            ["purple7"] = "#531dab",
            ["purple-8"] = "#391085",
            ["purple8"] = "#391085",
            ["purple-9"] = "#22075e",
            ["purple9"] = "#22075e",
            ["purple-10"] = "#120338",
            ["purple10"] = "#120338",
            ["cyan-1"] = "#e6fffb",
            ["cyan1"] = "#e6fffb",
            ["cyan-2"] = "#b5f5ec",
            ["cyan2"] = "#b5f5ec",
            ["cyan-3"] = "#87e8de",
            ["cyan3"] = "#87e8de",
            ["cyan-4"] = "#5cdbd3",
            ["cyan4"] = "#5cdbd3",
            ["cyan-5"] = "#36cfc9",
            ["cyan5"] = "#36cfc9",
            ["cyan-6"] = "#13c2c2",
            ["cyan6"] = "#13c2c2",
            ["cyan-7"] = "#08979c",
            ["cyan7"] = "#08979c",
            ["cyan-8"] = "#006d75",
            ["cyan8"] = "#006d75",
            ["cyan-9"] = "#00474f",
            ["cyan9"] = "#00474f",
            ["cyan-10"] = "#002329",
            ["cyan10"] = "#002329",
            ["green-1"] = "#f6ffed",
            ["green1"] = "#f6ffed",
            ["green-2"] = "#d9f7be",
            ["green2"] = "#d9f7be",
            ["green-3"] = "#b7eb8f",
            ["green3"] = "#b7eb8f",
            ["green-4"] = "#95de64",
            ["green4"] = "#95de64",
            ["green-5"] = "#73d13d",
            ["green5"] = "#73d13d",
            ["green-6"] = "#52c41a",
            ["green6"] = "#52c41a",
            ["green-7"] = "#389e0d",
            ["green7"] = "#389e0d",
            ["green-8"] = "#237804",
            ["green8"] = "#237804",
            ["green-9"] = "#135200",
            ["green9"] = "#135200",
            ["green-10"] = "#092b00",
            ["green10"] = "#092b00",
            ["magenta-1"] = "#fff0f6",
            ["magenta1"] = "#fff0f6",
            ["magenta-2"] = "#ffd6e7",
            ["magenta2"] = "#ffd6e7",
            ["magenta-3"] = "#ffadd2",
            ["magenta3"] = "#ffadd2",
            ["magenta-4"] = "#ff85c0",
            ["magenta4"] = "#ff85c0",
            ["magenta-5"] = "#f759ab",
            ["magenta5"] = "#f759ab",
            ["magenta-6"] = "#eb2f96",
            ["magenta6"] = "#eb2f96",
            ["magenta-7"] = "#c41d7f",
            ["magenta7"] = "#c41d7f",
            ["magenta-8"] = "#9e1068",
            ["magenta8"] = "#9e1068",
            ["magenta-9"] = "#780650",
            ["magenta9"] = "#780650",
            ["magenta-10"] = "#520339",
            ["magenta10"] = "#520339",
            ["pink-1"] = "#fff0f6",
            ["pink1"] = "#fff0f6",
            ["pink-2"] = "#ffd6e7",
            ["pink2"] = "#ffd6e7",
            ["pink-3"] = "#ffadd2",
            ["pink3"] = "#ffadd2",
            ["pink-4"] = "#ff85c0",
            ["pink4"] = "#ff85c0",
            ["pink-5"] = "#f759ab",
            ["pink5"] = "#f759ab",
            ["pink-6"] = "#eb2f96",
            ["pink6"] = "#eb2f96",
            ["pink-7"] = "#c41d7f",
            ["pink7"] = "#c41d7f",
            ["pink-8"] = "#9e1068",
            ["pink8"] = "#9e1068",
            ["pink-9"] = "#780650",
            ["pink9"] = "#780650",
            ["pink-10"] = "#520339",
            ["pink10"] = "#520339",
            ["red-1"] = "#fff1f0",
            ["red1"] = "#fff1f0",
            ["red-2"] = "#ffccc7",
            ["red2"] = "#ffccc7",
            ["red-3"] = "#ffa39e",
            ["red3"] = "#ffa39e",
            ["red-4"] = "#ff7875",
            ["red4"] = "#ff7875",
            ["red-5"] = "#ff4d4f",
            ["red5"] = "#ff4d4f",
            ["red-6"] = "#f5222d",
            ["red6"] = "#f5222d",
            ["red-7"] = "#cf1322",
            ["red7"] = "#cf1322",
            ["red-8"] = "#a8071a",
            ["red8"] = "#a8071a",
            ["red-9"] = "#820014",
            ["red9"] = "#820014",
            ["red-10"] = "#5c0011",
            ["red10"] = "#5c0011",
            ["orange-1"] = "#fff7e6",
            ["orange1"] = "#fff7e6",
            ["orange-2"] = "#ffe7ba",
            ["orange2"] = "#ffe7ba",
            ["orange-3"] = "#ffd591",
            ["orange3"] = "#ffd591",
            ["orange-4"] = "#ffc069",
            ["orange4"] = "#ffc069",
            ["orange-5"] = "#ffa940",
            ["orange5"] = "#ffa940",
            ["orange-6"] = "#fa8c16",
            ["orange6"] = "#fa8c16",
            ["orange-7"] = "#d46b08",
            ["orange7"] = "#d46b08",
            ["orange-8"] = "#ad4e00",
            ["orange8"] = "#ad4e00",
            ["orange-9"] = "#873800",
            ["orange9"] = "#873800",
            ["orange-10"] = "#612500",
            ["orange10"] = "#612500",
            ["yellow-1"] = "#feffe6",
            ["yellow1"] = "#feffe6",
            ["yellow-2"] = "#ffffb8",
            ["yellow2"] = "#ffffb8",
            ["yellow-3"] = "#fffb8f",
            ["yellow3"] = "#fffb8f",
            ["yellow-4"] = "#fff566",
            ["yellow4"] = "#fff566",
            ["yellow-5"] = "#ffec3d",
            ["yellow5"] = "#ffec3d",
            ["yellow-6"] = "#fadb14",
            ["yellow6"] = "#fadb14",
            ["yellow-7"] = "#d4b106",
            ["yellow7"] = "#d4b106",
            ["yellow-8"] = "#ad8b00",
            ["yellow8"] = "#ad8b00",
            ["yellow-9"] = "#876800",
            ["yellow9"] = "#876800",
            ["yellow-10"] = "#614700",
            ["yellow10"] = "#614700",
            ["volcano-1"] = "#fff2e8",
            ["volcano1"] = "#fff2e8",
            ["volcano-2"] = "#ffd8bf",
            ["volcano2"] = "#ffd8bf",
            ["volcano-3"] = "#ffbb96",
            ["volcano3"] = "#ffbb96",
            ["volcano-4"] = "#ff9c6e",
            ["volcano4"] = "#ff9c6e",
            ["volcano-5"] = "#ff7a45",
            ["volcano5"] = "#ff7a45",
            ["volcano-6"] = "#fa541c",
            ["volcano6"] = "#fa541c",
            ["volcano-7"] = "#d4380d",
            ["volcano7"] = "#d4380d",
            ["volcano-8"] = "#ad2102",
            ["volcano8"] = "#ad2102",
            ["volcano-9"] = "#871400",
            ["volcano9"] = "#871400",
            ["volcano-10"] = "#610b00",
            ["volcano10"] = "#610b00",
            ["geekblue-1"] = "#f0f5ff",
            ["geekblue1"] = "#f0f5ff",
            ["geekblue-2"] = "#d6e4ff",
            ["geekblue2"] = "#d6e4ff",
            ["geekblue-3"] = "#adc6ff",
            ["geekblue3"] = "#adc6ff",
            ["geekblue-4"] = "#85a5ff",
            ["geekblue4"] = "#85a5ff",
            ["geekblue-5"] = "#597ef7",
            ["geekblue5"] = "#597ef7",
            ["geekblue-6"] = "#2f54eb",
            ["geekblue6"] = "#2f54eb",
            ["geekblue-7"] = "#1d39c4",
            ["geekblue7"] = "#1d39c4",
            ["geekblue-8"] = "#10239e",
            ["geekblue8"] = "#10239e",
            ["geekblue-9"] = "#061178",
            ["geekblue9"] = "#061178",
            ["geekblue-10"] = "#030852",
            ["geekblue10"] = "#030852",
            ["gold-1"] = "#fffbe6",
            ["gold1"] = "#fffbe6",
            ["gold-2"] = "#fff1b8",
            ["gold2"] = "#fff1b8",
            ["gold-3"] = "#ffe58f",
            ["gold3"] = "#ffe58f",
            ["gold-4"] = "#ffd666",
            ["gold4"] = "#ffd666",
            ["gold-5"] = "#ffc53d",
            ["gold5"] = "#ffc53d",
            ["gold-6"] = "#faad14",
            ["gold6"] = "#faad14",
            ["gold-7"] = "#d48806",
            ["gold7"] = "#d48806",
            ["gold-8"] = "#ad6800",
            ["gold8"] = "#ad6800",
            ["gold-9"] = "#874d00",
            ["gold9"] = "#874d00",
            ["gold-10"] = "#613400",
            ["gold10"] = "#613400",
            ["lime-1"] = "#fcffe6",
            ["lime1"] = "#fcffe6",
            ["lime-2"] = "#f4ffb8",
            ["lime2"] = "#f4ffb8",
            ["lime-3"] = "#eaff8f",
            ["lime3"] = "#eaff8f",
            ["lime-4"] = "#d3f261",
            ["lime4"] = "#d3f261",
            ["lime-5"] = "#bae637",
            ["lime5"] = "#bae637",
            ["lime-6"] = "#a0d911",
            ["lime6"] = "#a0d911",
            ["lime-7"] = "#7cb305",
            ["lime7"] = "#7cb305",
            ["lime-8"] = "#5b8c00",
            ["lime8"] = "#5b8c00",
            ["lime-9"] = "#3f6600",
            ["lime9"] = "#3f6600",
            ["lime-10"] = "#254000",
            ["lime10"] = "#254000",
            ["colorText"] = "rgba(0, 0, 0, 0.88)",
            ["colorTextSecondary"] = "rgba(0, 0, 0, 0.65)",
            ["colorTextTertiary"] = "rgba(0, 0, 0, 0.45)",
            ["colorTextQuaternary"] = "rgba(0, 0, 0, 0.25)",
            ["colorFill"] = "rgba(0, 0, 0, 0.15)",
            ["colorFillSecondary"] = "rgba(0, 0, 0, 0.06)",
            ["colorFillTertiary"] = "rgba(0, 0, 0, 0.04)",
            ["colorFillQuaternary"] = "rgba(0, 0, 0, 0.02)",
            ["colorBgLayout"] = "#f5f5f5",
            ["colorBgContainer"] = "#ffffff",
            ["colorBgElevated"] = "#ffffff",
            ["colorBgSpotlight"] = "rgba(0, 0, 0, 0.85)",
            ["colorBgBlur"] = "transparent",
            ["colorBorder"] = "#d9d9d9",
            ["colorBorderSecondary"] = "#f0f0f0",
            ["colorPrimaryBg"] = "#e6f4ff",
            ["colorPrimaryBgHover"] = "#bae0ff",
            ["colorPrimaryBorder"] = "#91caff",
            ["colorPrimaryBorderHover"] = "#69b1ff",
            ["colorPrimaryHover"] = "#4096ff",
            ["colorPrimaryActive"] = "#0958d9",
            ["colorPrimaryTextHover"] = "#4096ff",
            ["colorPrimaryText"] = "#1677ff",
            ["colorPrimaryTextActive"] = "#0958d9",
            ["colorSuccessBg"] = "#f6ffed",
            ["colorSuccessBgHover"] = "#d9f7be",
            ["colorSuccessBorder"] = "#b7eb8f",
            ["colorSuccessBorderHover"] = "#95de64",
            ["colorSuccessHover"] = "#95de64",
            ["colorSuccessActive"] = "#389e0d",
            ["colorSuccessTextHover"] = "#73d13d",
            ["colorSuccessText"] = "#52c41a",
            ["colorSuccessTextActive"] = "#389e0d",
            ["colorErrorBg"] = "#fff2f0",
            ["colorErrorBgHover"] = "#fff1f0",
            ["colorErrorBorder"] = "#ffccc7",
            ["colorErrorBorderHover"] = "#ffa39e",
            ["colorErrorHover"] = "#ff7875",
            ["colorErrorActive"] = "#d9363e",
            ["colorErrorTextHover"] = "#ff7875",
            ["colorErrorText"] = "#ff4d4f",
            ["colorErrorTextActive"] = "#d9363e",
            ["colorWarningBg"] = "#fffbe6",
            ["colorWarningBgHover"] = "#fff1b8",
            ["colorWarningBorder"] = "#ffe58f",
            ["colorWarningBorderHover"] = "#ffd666",
            ["colorWarningHover"] = "#ffd666",
            ["colorWarningActive"] = "#d48806",
            ["colorWarningTextHover"] = "#ffc53d",
            ["colorWarningText"] = "#faad14",
            ["colorWarningTextActive"] = "#d48806",
            ["colorInfoBg"] = "#e6f4ff",
            ["colorInfoBgHover"] = "#bae0ff",
            ["colorInfoBorder"] = "#91caff",
            ["colorInfoBorderHover"] = "#69b1ff",
            ["colorInfoHover"] = "#69b1ff",
            ["colorInfoActive"] = "#0958d9",
            ["colorInfoTextHover"] = "#4096ff",
            ["colorInfoText"] = "#1677ff",
            ["colorInfoTextActive"] = "#0958d9",
            ["colorLinkHover"] = "#69b1ff",
            ["colorLinkActive"] = "#0958d9",
            ["colorBgMask"] = "rgba(0, 0, 0, 0.45)",
            ["colorWhite"] = "#fff",
            ["fontSizeSM"] = 12d,
            ["fontSizeLG"] = 16d,
            ["fontSizeXL"] = 20d,
            ["fontSizeHeading1"] = 38d,
            ["fontSizeHeading2"] = 30d,
            ["fontSizeHeading3"] = 24d,
            ["fontSizeHeading4"] = 20d,
            ["fontSizeHeading5"] = 16d,
            ["lineHeight"] = 1.5714285714285714d,
            ["lineHeightLG"] = 1.5d,
            ["lineHeightSM"] = 1.6666666666666667d,
            ["lineHeightHeading1"] = 1.2105263157894737d,
            ["lineHeightHeading2"] = 1.2666666666666666d,
            ["lineHeightHeading3"] = 1.3333333333333333d,
            ["lineHeightHeading4"] = 1.4d,
            ["lineHeightHeading5"] = 1.5d,
            ["sizeXXL"] = 48d,
            ["sizeXL"] = 32d,
            ["sizeLG"] = 24d,
            ["sizeMD"] = 20d,
            ["sizeMS"] = 16d,
            ["size"] = 16d,
            ["sizeSM"] = 12d,
            ["sizeXS"] = 8d,
            ["sizeXXS"] = 4d,
            ["controlHeightSM"] = 24d,
            ["controlHeightXS"] = 16d,
            ["controlHeightLG"] = 40d,
            ["motionDurationFast"] = "0.1s",
            ["motionDurationMid"] = "0.2s",
            ["motionDurationSlow"] = "0.3s",
            ["lineWidthBold"] = 2d,
            ["borderRadiusXS"] = 2d,
            ["borderRadiusSM"] = 4d,
            ["borderRadiusLG"] = 8d,
            ["borderRadiusOuter"] = 4d,
            ["colorFillContent"] = "rgba(0, 0, 0, 0.06)",
            ["colorFillContentHover"] = "rgba(0, 0, 0, 0.15)",
            ["colorFillAlter"] = "rgba(0, 0, 0, 0.02)",
            ["colorBgContainerDisabled"] = "rgba(0, 0, 0, 0.04)",
            ["colorBorderBg"] = "#ffffff",
            ["colorSplit"] = "rgba(5, 5, 5, 0.06)",
            ["colorTextPlaceholder"] = "rgba(0, 0, 0, 0.25)",
            ["colorTextDisabled"] = "rgba(0, 0, 0, 0.25)",
            ["colorTextHeading"] = "rgba(0, 0, 0, 0.88)",
            ["colorTextLabel"] = "rgba(0, 0, 0, 0.65)",
            ["colorTextDescription"] = "rgba(0, 0, 0, 0.45)",
            ["colorTextLightSolid"] = "#fff",
            ["colorHighlight"] = "#ff4d4f",
            ["colorBgTextHover"] = "rgba(0, 0, 0, 0.06)",
            ["colorBgTextActive"] = "rgba(0, 0, 0, 0.15)",
            ["colorIcon"] = "rgba(0, 0, 0, 0.45)",
            ["colorIconHover"] = "rgba(0, 0, 0, 0.88)",
            ["colorErrorOutline"] = "rgba(255, 38, 5, 0.06)",
            ["colorWarningOutline"] = "rgba(255, 215, 5, 0.1)",
            ["fontSizeIcon"] = 12d,
            ["lineWidthFocus"] = 4d,
            ["controlOutlineWidth"] = 2d,
            ["controlInteractiveSize"] = 16d,
            ["controlItemBgHover"] = "rgba(0, 0, 0, 0.04)",
            ["controlItemBgActive"] = "#e6f4ff",
            ["controlItemBgActiveHover"] = "#bae0ff",
            ["controlItemBgActiveDisabled"] = "rgba(0, 0, 0, 0.15)",
            ["controlTmpOutline"] = "rgba(0, 0, 0, 0.02)",
            ["controlOutline"] = "rgba(5, 145, 255, 0.1)",
            ["fontWeightStrong"] = 600d,
            ["opacityLoading"] = 0.65d,
            ["linkDecoration"] = "none",
            ["linkHoverDecoration"] = "none",
            ["linkFocusDecoration"] = "none",
            ["controlPaddingHorizontal"] = 12d,
            ["controlPaddingHorizontalSM"] = 8d,
            ["paddingXXS"] = 4d,
            ["paddingXS"] = 8d,
            ["paddingSM"] = 12d,
            ["padding"] = 16d,
            ["paddingMD"] = 20d,
            ["paddingLG"] = 24d,
            ["paddingXL"] = 32d,
            ["paddingContentHorizontalLG"] = 24d,
            ["paddingContentVerticalLG"] = 16d,
            ["paddingContentHorizontal"] = 16d,
            ["paddingContentVertical"] = 12d,
            ["paddingContentHorizontalSM"] = 16d,
            ["paddingContentVerticalSM"] = 8d,
            ["marginXXS"] = 4d,
            ["marginXS"] = 8d,
            ["marginSM"] = 12d,
            ["margin"] = 16d,
            ["marginMD"] = 20d,
            ["marginLG"] = 24d,
            ["marginXL"] = 32d,
            ["marginXXL"] = 48d,
            ["boxShadow"] = "\n      0 6px 16px 0 rgba(0, 0, 0, 0.08),\n      0 3px 6px -4px rgba(0, 0, 0, 0.12),\n      0 9px 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowSecondary"] = "\n      0 6px 16px 0 rgba(0, 0, 0, 0.08),\n      0 3px 6px -4px rgba(0, 0, 0, 0.12),\n      0 9px 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowTertiary"] = "\n      0 1px 2px 0 rgba(0, 0, 0, 0.03),\n      0 1px 6px -1px rgba(0, 0, 0, 0.02),\n      0 2px 4px 0 rgba(0, 0, 0, 0.02)\n    ",
            ["screenXS"] = 480d,
            ["screenXSMin"] = 480d,
            ["screenXSMax"] = 575d,
            ["screenSM"] = 576d,
            ["screenSMMin"] = 576d,
            ["screenSMMax"] = 767d,
            ["screenMD"] = 768d,
            ["screenMDMin"] = 768d,
            ["screenMDMax"] = 991d,
            ["screenLG"] = 992d,
            ["screenLGMin"] = 992d,
            ["screenLGMax"] = 1199d,
            ["screenXL"] = 1200d,
            ["screenXLMin"] = 1200d,
            ["screenXLMax"] = 1599d,
            ["screenXXL"] = 1600d,
            ["screenXXLMin"] = 1600d,
            ["boxShadowPopoverArrow"] = "2px 2px 5px rgba(0, 0, 0, 0.05)",
            ["boxShadowCard"] = "\n      0 1px 2px -2px rgba(0, 0, 0, 0.16),\n      0 3px 6px 0 rgba(0, 0, 0, 0.12),\n      0 5px 12px 4px rgba(0, 0, 0, 0.09)\n    ",
            ["boxShadowDrawerRight"] = "\n      -6px 0 16px 0 rgba(0, 0, 0, 0.08),\n      -3px 0 6px -4px rgba(0, 0, 0, 0.12),\n      -9px 0 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowDrawerLeft"] = "\n      6px 0 16px 0 rgba(0, 0, 0, 0.08),\n      3px 0 6px -4px rgba(0, 0, 0, 0.12),\n      9px 0 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowDrawerUp"] = "\n      0 6px 16px 0 rgba(0, 0, 0, 0.08),\n      0 3px 6px -4px rgba(0, 0, 0, 0.12),\n      0 9px 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowDrawerDown"] = "\n      0 -6px 16px 0 rgba(0, 0, 0, 0.08),\n      0 -3px 6px -4px rgba(0, 0, 0, 0.12),\n      0 -9px 28px 8px rgba(0, 0, 0, 0.05)\n    ",
            ["boxShadowTabsOverflowLeft"] = "inset 10px 0 8px -8px rgba(0, 0, 0, 0.08)",
            ["boxShadowTabsOverflowRight"] = "inset -10px 0 8px -8px rgba(0, 0, 0, 0.08)",
            ["boxShadowTabsOverflowTop"] = "inset 0 10px 8px -8px rgba(0, 0, 0, 0.08)",
            ["boxShadowTabsOverflowBottom"] = "inset 0 -10px 8px -8px rgba(0, 0, 0, 0.08)"        
        };

        public static GlobalToken Derivative()
        {
            return _token;
        }
    }
}
