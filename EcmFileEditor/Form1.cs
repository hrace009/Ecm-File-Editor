using LBLIBRARY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcmFileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Combine = new ActionList(CombineActName, this);
        }
        EcmFileStructure ecm;
        SmdFile smd;
        LCombobox lcombobox;
        ActionList Combine;
        int ActionRowIndex;
        EcmFileEditor.TranslatorService.LanguageServiceClient translator = new EcmFileEditor.TranslatorService.LanguageServiceClient();

        static List<string> GetFiles(string path)
        {
            if (Directory.Exists(path))
            {
                return Directory.GetFiles(path, "*.ecm").ToList();

            }
            return new List<string>();
        }
        public static void WriteLog(string text)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Luka\Desktop\Errors.txt", true, Encoding.UTF8);
            sw.WriteLine(text);
            sw.Close();

        }
        void SetControlEnable(Control co, bool val)
        {
            foreach (Control item in co.Controls)
            {
                if (item is TextBox || item is RichTextBox || item is DataGridView)
                {
                    item.Enabled = val;
                }
                else if (item is GroupBox || item is TabControl)
                {
                    SetControlEnable(item, val);
                }
                else if (item is TabPage)
                {
                    SetControlEnable(item, val);
                }
            }
        }
        public void SortControls(int v)
        {
            if (v < 71)
            {
                AudioEventGroupEnableGrid.Enabled = false;
                ParticleBonesCount.Enabled = false;
                DGfxUseFixedPoint.Enabled = false;
                ActionSfxPercentStart.Enabled = false;
                ActionSfxGroup.Enabled = false;
                ActionGfxUseFixedPoint.Enabled = false;
                if (v < 67)
                {
                    Action107TypeUseFileScale.Enabled = false;
                    if (v < 66)
                    {
                        DGfxRotWithModel.Enabled = false;
                        if (v < 65)
                        {
                            ActionSfxAbsoluteSound.Enabled = false;
                            ActionSfxFixSpeed.Enabled = false;
                            ActionSfxSilentHeader.Enabled = false;
                            ActionAttackAtkOrient.Enabled = false;
                            ActionGfxRotWithModel.Enabled = false;
                            if (v < 62)
                            {
                                DGfxCustomData.Enabled = false;
                                ActionSfxCustomPath.Enabled = false;
                                ActionGfxCustomData.Enabled = false;
                                if (v < 60)
                                {
                                    PSFileVersion.Enabled = false;
                                    if (v < 59)
                                    {
                                        DGfxCustomPath.Enabled = false;
                                        ActionSfxCustomPath.Enabled = false;
                                        ActionScriptUsage.Enabled = false;
                                        ActionGfxCustomPath.Enabled = false;
                                        if (v < 57)
                                        {
                                            ShaderFile.Enabled = false;
                                            ShaderTex.Enabled = false;
                                            PSConstCount.Enabled = false;
                                            if (v < 56)
                                            {
                                                Action108TypeApplyChild.Enabled = false;
                                                if (v < 54)
                                                {
                                                    DGfxFxFiles.Enabled = false;
                                                    ActionSfxFxFiles.Enabled = false;
                                                    DGfxDelayTime.Enabled = false;
                                                    ActionSfxVolMin.Enabled = false;
                                                    ActionSfxVolMax.Enabled = false;
                                                    ActionSfxPitchMin.Enabled = false;
                                                    ActionSfxPitchMax.Enabled = false;
                                                    ActionGfxDelayTime.Enabled = false;
                                                    if (v < 52)
                                                    {
                                                        EmmisiveCol.Enabled = false;
                                                        if (v < 49)
                                                        {
                                                            ActionStopChildAct.Enabled = false;
                                                            ActionResetMtl.Enabled = false;
                                                            if (v < 48)
                                                            {
                                                                RenderEdge.Enabled = false;
                                                                if (v < 45)
                                                                {
                                                                    RenderModel.Enabled = false;
                                                                    if (v < 43)
                                                                    {
                                                                        CanCastShadow.Enabled = false;
                                                                        if (v < 42)
                                                                        {
                                                                            ActionChildTransTime.Enabled = false;
                                                                            if (v < 40)
                                                                            {
                                                                                ActionPlaySpeed.Enabled = false;
                                                                                if (v < 39)
                                                                                {
                                                                                    ActionAttackAtkUseDelay.Enabled = false;
                                                                                    ActionAttackAtkDelayNum.Enabled = false;
                                                                                    ActionAttackDelayTime1.Enabled = false;
                                                                                    ActionAttackDelayTime2.Enabled = false;
                                                                                    if (v < 36)
                                                                                    {
                                                                                        BaseActLoopMinNum.Enabled = false;
                                                                                        BaseActLoopMaxNum.Enabled = false;
                                                                                        if (v < 35)
                                                                                        {
                                                                                            DGfxRelToECM.Enabled = false;
                                                                                            ActionGfxRelToEcm.Enabled = false;
                                                                                            if (v < 33)
                                                                                            {
                                                                                                AutoUpdata.Enabled = false;
                                                                                                if (v < 32)
                                                                                                {
                                                                                                    ChannelCount.Enabled = false;
                                                                                                    ChannelCount2.Enabled = false;
                                                                                                    Channels.Enabled = false;
                                                                                                    ActionRanks.Enabled = false;
                                                                                                    ActionRanksCount.Enabled = false;
                                                                                                    ActionEventChannel.Enabled = false;
                                                                                                    if (v < 28)
                                                                                                    {
                                                                                                        NewScale.Enabled = false;
                                                                                                        if (v < 27)
                                                                                                        {
                                                                                                            DefSpeed.Enabled = false;
                                                                                                            if (v < 25)
                                                                                                            {
                                                                                                                SetControlEnable(tabPage20, false);
                                                                                                                if (v < 23)
                                                                                                                {
                                                                                                                    DGfxOuterPath.Enabled = false;
                                                                                                                    ActionGfxOuterPath.Enabled = false;
                                                                                                                    if (v < 22)
                                                                                                                    {
                                                                                                                        DGfxAlpha.Enabled = false;
                                                                                                                        ActionGfxAlpha.Enabled = false;
                                                                                                                        SetControlEnable(tabPage20, false);
                                                                                                                        if (v < 21)
                                                                                                                        {
                                                                                                                            SrcBlend.Enabled = false;
                                                                                                                            DestBlend.Enabled = false;
                                                                                                                            if (v < 20)
                                                                                                                            {
                                                                                                                                DGfxTimeSpan.Enabled = false;
                                                                                                                                ActionsGfxTimeSpan.Enabled = false;
                                                                                                                                ActionSfxTimeSpan.Enabled = false;
                                                                                                                                ActionChildTimeSpan.Enabled = false;
                                                                                                                                ActionColorTimeSpan.Enabled = false;
                                                                                                                                if (v < 19)
                                                                                                                                {
                                                                                                                                    DGfxHookRot.Enabled = false;
                                                                                                                                    ActionGfxRot.Enabled = false;
                                                                                                                                    ActionSfxRot.Enabled = false;
                                                                                                                                    if (v < 18)
                                                                                                                                    {
                                                                                                                                        OrgColor.Enabled = false;
                                                                                                                                        OuterNum.Enabled = false;
                                                                                                                                        OuterNumValues.Enabled = false;
                                                                                                                                        BoneNum.Enabled = false;
                                                                                                                                        Bones.Enabled = false;
                                                                                                                                        BonesBoneIndex.Enabled = false;
                                                                                                                                        BonesScaleType.Enabled = false;
                                                                                                                                        BoneScaleX.Enabled = false;
                                                                                                                                        BoneScaleY.Enabled = false;
                                                                                                                                        BoneScaleZ.Enabled = false;
                                                                                                                                        DGfxUseModelalpha.Enabled = false;
                                                                                                                                        DGfxStartTime.Enabled = false;
                                                                                                                                        DGfxOnce.Enabled = false;
                                                                                                                                        ActionsGfxStartTime.Enabled = false;
                                                                                                                                        ActionsGfxOnce.Enabled = false;
                                                                                                                                        ActionSfxStartTime.Enabled = false;
                                                                                                                                        ActionSfxOnce.Enabled = false;
                                                                                                                                        ActionSfxUseModelAlpha.Enabled = false;
                                                                                                                                        ActionGfxUseModelAlpha.Enabled = false;
                                                                                                                                        if (v < 15)
                                                                                                                                        {
                                                                                                                                            ActionSfxBindParent.Enabled = false;

                                                                                                                                            if (v < 14)
                                                                                                                                            {
                                                                                                                                                SetControlEnable(tabPage1, false);
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (v >= 36)
            {
                BaseActLoopCount.Enabled = false;
            }
            if (v >= 54)
            {
                DGfxPath.Enabled = false;
                ActionsGfxPath.Enabled = false;
                ActionsSfxPath.Enabled = false;
            }
            if (v >= 18)
            {
                DGfxFxStartTime.Enabled = false;
                ActionGfxFxStartTime.Enabled = false;
                ActionSfxFxStartTime.Enabled = false;
            }
            if (v >= 54)
            {
                ActionSfxVolume.Enabled = false;
            }
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Ecm File";
            ofd.Filter = "Ecm Files|*.ecm|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetControlEnable(this, true);
                //var files = Directory.GetFiles(@"C:\Users\Лука\Desktop\GameFiles\GameFiles", "*.ecm", SearchOption.AllDirectories);
                // foreach (var item in files)
                // {
                //     try
                //     {
                //         EcmFile ec = new EcmFile(item);
                //     }
                //     catch { }
                // }
                OpenEcm.TextBoxText = ofd.FileName;
                ecm = new EcmFileStructure(ofd.FileName);
                SortControls(ecm.Version);
                Version.Text = ecm.Version.ToString();
                SmdPath.Text = ecm.SmdPath;
                AutoUpdata.Text = ecm.AutoUpdata.ToString();
                OrgColor.Text = ecm.OrgColor.ToString();
                EmmisiveCol.Text = ecm.EmissiveCol.ToString();
                SrcBlend.Text = ecm.SrcBlend.ToString();
                DestBlend.Text = ecm.DestBlend.ToString();
                OuterNum.Text = ecm.OuterNum.ToString();
                OuterNumValues.Rows.Clear();
                for (int i = 0; i < ecm.OuterNum; i++)
                {
                    OuterNumValues.Rows.Add(ecm.Outers[i]);
                }
                NewScale.Text = ecm.NewScale.ToString();
                BoneNum.Text = ecm.Bones.Count.ToString();
                Bones.Rows.Clear();
                for (int i = 0; i < ecm.Bones.Count; i++)
                {
                    Bones.Rows.Add(ecm.Bones[i].BoneIndex as object);
                }
                DefSpeed.Text = ecm.DefSpeed.ToString();
                CanCastShadow.Text = ecm.CanCastShadow.ToString();
                RenderModel.Text = ecm.RenderModel.ToString();
                RenderEdge.Text = ecm.RenderEdge.ToString();
                PSFileVersion.Text = ecm.PSFileVersion.ToString();
                PSConstCount.Text = ecm.PSFileVersion.ToString();
                ParticleBonesCount.Text = ecm.ParticleBonesCount.ToString();
                ChannelCount.Text = ecm.ChannelCount.ToString();
                ChannelCount2.Text = ecm.ChannelMask.Count.ToString();
                Channels.Rows.Clear();
                for (int i = 0; i < ecm.ChannelMask.Count; i++)
                {
                    Channels.Rows.Add(ecm.ChannelMask[i] as object);
                }
                ShaderFile.Text = ecm.ShaderFile;
                ShaderTex.Text = ecm.ShaderTex;
                AudioEventGroupEnableGrid.Rows.Clear();
                for (int i = 0; i < 11; i++)
                {
                    AudioEventGroupEnableGrid.Rows.Add(ecm.AudioEventGroupEnable[i] as object);
                }
                PhysFileName.Text = ecm.physfilename;
                HooksCount.Text = ecm.Hooks.Count.ToString();
                HooksGrid.Rows.Clear();
                for (int i = 0; i < ecm.Hooks.Count; i++)
                {
                    HooksGrid.Rows.Add((object)ecm.Hooks[i].Name);
                }
                ChildsGrid.Rows.Clear();
                for (int i = 0; i < ecm.Childs.Count; i++)
                {
                    ChildsGrid.Rows.Add((object)ecm.Childs[i].ChildName);
                }
                Gfxs.Rows.Clear();
                for (int i = 0; i < ecm.Gfxs.Count; i++)
                {
                    Gfxs.Rows.Add((object)(i + 1));
                }
                Actions.Rows.Clear();
                for (int i = 0; i < ecm.Actions.Count; i++)
                {
                    Actions.Rows.Add(ecm.Actions[i].CombineActName);
                }
                AddiSkins.Rows.Clear();
                for (int i = 0; i < ecm.AddiSkins.Count; i++)
                {
                    AddiSkins.Rows.Add(ecm.AddiSkins[i]);
                }
                EndScripts.Rows.Clear();
                for (int i = 0; i < ecm.Scripts.Count; i++)
                {
                    EndScripts.Rows.Add(ecm.Scripts[i].Id, ecm.Scripts[i].LinesCount);
                }
            }
        }
        private void Bones_CurrentCellChanged(object sender, EventArgs e)
        {
            if (Bones.CurrentRow == null) return;
            if (Bones.CurrentRow.Index == -1) return;
            int Index = Bones.CurrentRow.Index;
            BonesBoneIndex.Text = ecm.Bones[Index].BoneIndex.ToString();
            BonesScaleType.Text = ecm.Bones[Index].BoneSclType.ToString();
            BoneScaleX.Text = ecm.Bones[Index].BoneScale[0].ToString();
            BoneScaleY.Text = ecm.Bones[Index].BoneScale[1].ToString();
            BoneScaleZ.Text = ecm.Bones[Index].BoneScale[2].ToString();
        }
        private void HooksGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (HooksGrid.CurrentRow == null) return;
            if (HooksGrid.CurrentRow.Index == -1) return;
            int Index = HooksGrid.CurrentRow.Index;
            HookName.Text = ecm.Hooks[Index].Name;
            HookId.Text = ecm.Hooks[Index].Id.ToString();
            HookScale.Text = ecm.Hooks[Index].Scale.ToString();
            Hook1X.Text = ecm.Hooks[Index].Hook1[0].ToString();
            Hook2X.Text = ecm.Hooks[Index].Hook2[0].ToString();
            Hook3X.Text = ecm.Hooks[Index].Hook3[0].ToString();
            Hook4X.Text = ecm.Hooks[Index].Hook4[0].ToString();

            Hook1Y.Text = ecm.Hooks[Index].Hook1[1].ToString();
            Hook2Y.Text = ecm.Hooks[Index].Hook2[1].ToString();
            Hook3Y.Text = ecm.Hooks[Index].Hook3[1].ToString();
            Hook4Y.Text = ecm.Hooks[Index].Hook4[1].ToString();

            Hook1Z.Text = ecm.Hooks[Index].Hook1[2].ToString();
            Hook2Z.Text = ecm.Hooks[Index].Hook2[2].ToString();
            Hook3Z.Text = ecm.Hooks[Index].Hook3[2].ToString();
            Hook4Z.Text = ecm.Hooks[Index].Hook4[2].ToString();
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.FileName = "Ecm";
            ofd.Filter = "Ecm Files|*.ecm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ecm.Save(ofd.FileName, ecm.Version);
            }
        }
        private void Gfxs_CurrentCellChanged(object sender, EventArgs e)
        {
            DGfxFxFiles.Rows.Clear();
            DGfxParams.Rows.Clear();
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            int q = Gfxs.CurrentRow.Index;
            DGfxPath.Text = ecm.Gfxs[q].FxFilePath;
            DGfxHookName.Text = ecm.Gfxs[q].HookName;
            DGfxStartTime.Text = ecm.Gfxs[q].StartTime.ToString();
            DGfxFxStartTime.Text = ecm.Gfxs[q].FxStartTime.ToString();
            DGfxHookX.Text = ecm.Gfxs[q].HookOffset[0].ToString();
            DGfxHookY.Text = ecm.Gfxs[q].HookOffset[1].ToString();
            DGfxHookZ.Text = ecm.Gfxs[q].HookOffset[2].ToString();
            DGfxHookYaw.Text = ecm.Gfxs[q].HookYaw.ToString();
            DGfxHookPitch.Text = ecm.Gfxs[q].HookPitch.ToString();
            DGfxHookRot.Text = ecm.Gfxs[q].HookRot.ToString();
            DGfxTimeSpan.Text = ecm.Gfxs[q].TimeSpan.ToString();
            DGfxOnce.Text = ecm.Gfxs[q].Once.ToString();
            DGfxBindParent.Text = ecm.Gfxs[q].BindParent.ToString();
            DGfxHookRot.Text = ecm.Gfxs[q].HookRot.ToString();
            DGfxFadeOut.Text = ecm.Gfxs[q].FadeOut.ToString();
            DGfxOuterPath.Text = ecm.Gfxs[q].GfxOuterPath.ToString();
            DGfxScale.Text = ecm.Gfxs[q].GfxScale.ToString();
            DGfxAlpha.Text = ecm.Gfxs[q].GfxAlpha.ToString();
            DGfxSpeed.Text = ecm.Gfxs[q].GfxSpeed.ToString();
            DGfxUseModelalpha.Text = ecm.Gfxs[q].UseModelAlpha.ToString();
            DGfxDelayTime.Text = ecm.Gfxs[q].GfxDelayTime.ToString();
            DGfxRelToECM.Text = ecm.Gfxs[q].GfxRelToECM.ToString();
            DGfxCustomPath.Text = ecm.Gfxs[q].CustomPath.ToString();
            DGfxCustomData.Text = ecm.Gfxs[q].CustomData.ToString();
            DGfxRotWithModel.Text = ecm.Gfxs[q].GfxRotWithModel.ToString();
            DGfxUseFixedPoint.Text = ecm.Gfxs[q].GfxUseFixedPoint.ToString();
            for (int i = 0; i < ecm.Gfxs[q].FxFiles.Count; i++)
            {
                DGfxFxFiles.Rows.Add(ecm.Gfxs[q].FxFiles[i]);
            }
            for (int i = 0; i < ecm.Gfxs[q].GfxParams.Count; i++)
            {
                DGfxParams.Rows.Add(ecm.Gfxs[q].GfxParams[i].ParamId,
                    ecm.Gfxs[q].GfxParams[i].ParamEleName,
                    ecm.Gfxs[q].GfxParams[i].ParamDataType,
                    ecm.Gfxs[q].GfxParams[i].ParamDataIsCmd,
                    ecm.Gfxs[q].GfxParams[i].ParamDataHook
                    );
            }
        }
        public string Translate(string Text, string From, string To)
        {
            return translator.Translate("763743C8043FA427227700179E653860B731D443", Text, From, To);
        }
        private void Actions_CurrentCellChanged(object sender, EventArgs e)
        {
            BaseActions.Rows.Clear();
            ActionGfxs.Rows.Clear();
            ActionSfxs.Rows.Clear();
            ActionAttacks.Rows.Clear();
            ActionChilds.Rows.Clear();
            ActionScripts.Rows.Clear();
            ActionColors.Rows.Clear();
            Action107Types.Rows.Clear();
            Action108Types.Rows.Clear();
            ActionRanks.Rows.Clear();
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            this.ActionRowIndex = Actions.CurrentRow.Index;
            CombineActName.Text = ecm.Actions[ActionRowIndex].CombineActName;
            if (checkBox1.Checked)
                CombineActNameTranslated.Text = Translate(ecm.Actions[ActionRowIndex].CombineActName, "zh-CHS", comboBox1.SelectedItem.ToString());
            for (int i = 0; i < ecm.Actions[ActionRowIndex].BaseActions.Count; i++)
            {
                BaseActions.Rows.Add(ecm.Actions[ActionRowIndex].BaseActions[i].BaseActName);
            }
            ActionEventCount.Text = ecm.Actions[ActionRowIndex].EventCount.ToString();
            ActionLoopCount.Text = ecm.Actions[ActionRowIndex].LoopCount.ToString();
            ActionEventChannel.Text = ecm.Actions[ActionRowIndex].EventChannel.ToString();
            ActionPlaySpeed.Text = ecm.Actions[ActionRowIndex].PlaySpeed.ToString();
            ActionStopChildAct.Text = ecm.Actions[ActionRowIndex].StopChildAct.ToString();
            ActionResetMtl.Text = ecm.Actions[ActionRowIndex].ResetMtl.ToString();
            ActionRanksCount.Text = ecm.Actions[ActionRowIndex].Ranks.Count.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Ranks.Count; i++)
            {
                ActionRanks.Rows.Add(ecm.Actions[ActionRowIndex].Ranks[i].Channel, ecm.Actions[ActionRowIndex].Ranks[i].RankT);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Gfxs.Count + 1; i++)
            {
                ActionGfxs.Rows.Add((object)i);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Sfx.Count + 1; i++)
            {
                ActionSfxs.Rows.Add((object)i);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Attacks.Count + 1; i++)
            {
                ActionAttacks.Rows.Add((object)i);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].ChildActs.Count + 1; i++)
            {
                ActionChilds.Rows.Add((object)i);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Colors.Count + 1; i++)
            {
                ActionColors.Rows.Add((object)i);
            }
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Scripts.Count + 1; i++)
            {
                ActionScripts.Rows.Add((object)i);
            }
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Type107s.Count; i++)
            {
                Action107Types.Rows.Add((object)i);
            }
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Type108s.Count; i++)
            {
                Action108Types.Rows.Add((object)i);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] {
            "ar", "bg", "ca", "zh-CHS", "zh-CHT", "cs", "da", "nl", "en", "et", "fi", "fr", "de", "el", "ht", "he",
            "hi", "mww", "hu", "id", "it", "ja", "tlh", "tlh-Qaak", "ko", "lv", "lt", "ms", "mt", "no", "fa", "pl",
            "pt", "ro", "ru", "sk", "sl", "es", "sv", "th", "tr", "uk", "ur", "vi"
         });
            comboBox1.SelectedItem = "en";
        }
        private void BaseActions_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BaseActions.CurrentRow == null) return;
            if (BaseActions.CurrentRow.Index == -1) return;
            int q = BaseActions.CurrentRow.Index;
            BaseActName.Text = ecm.Actions[Actions.CurrentRow.Index].BaseActions[q].BaseActName;
            if (checkBox1.Checked)
                BaseActNameTranslated.Text = Translate(BaseActName.Text, "zh-CHS", comboBox1.SelectedItem.ToString());
            BaseActStartTime.Text = ecm.Actions[Actions.CurrentRow.Index].BaseActions[q].ActStartTime.ToString();
            BaseActLoopCount.Text = ecm.Actions[Actions.CurrentRow.Index].BaseActions[q].LoopCount.ToString();
            BaseActLoopMinNum.Text = ecm.Actions[Actions.CurrentRow.Index].BaseActions[q].LoopMinNum.ToString();
            BaseActLoopMaxNum.Text = ecm.Actions[Actions.CurrentRow.Index].BaseActions[q].LoopMaxNum.ToString();
        }
        private void ActionGfxs_CurrentCellChanged(object sender, EventArgs e)
        {
            ActionsGfxFxFiles.Rows.Clear();
            ActionGfxParams.Rows.Clear();
            if (ActionGfxs.CurrentRow == null) return;
            if (ActionGfxs.CurrentRow.Index == -1) return;
            int q = ActionGfxs.CurrentRow.Index;
            ActionsGfxPath.Text = ecm.Actions[ActionRowIndex].Gfxs[q].FxFilePath;
            ActionsGfxHookName.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookName;
            ActionsGfxStartTime.Text = ecm.Actions[ActionRowIndex].Gfxs[q].StartTime.ToString();
            ActionsGfxTimeSpan.Text = ecm.Actions[ActionRowIndex].Gfxs[q].TimeSpan.ToString();
            ActionsGfxOnce.Text = ecm.Actions[ActionRowIndex].Gfxs[q].Once.ToString();
            ActionsGfxBindParent.Text = ecm.Actions[ActionRowIndex].Gfxs[q].BindParent.ToString();
            ActionsGfxFadeOut.Text = ecm.Actions[ActionRowIndex].Gfxs[q].FadeOut.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Gfxs[q].FxFiles.Count; i++)
            {
                ActionsGfxFxFiles.Rows.Add(ecm.Actions[ActionRowIndex].Gfxs[q].FxFiles[i]);
            }
            ActionGfxHookX.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookOffset[0].ToString();
            ActionGfxHookY.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookOffset[1].ToString();
            ActionGfxHookZ.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookOffset[2].ToString();
            ActionGfxHookYaw.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookYaw.ToString();
            ActionGfxHookPitch.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookPitch.ToString();
            ActionGfxRot.Text = ecm.Actions[ActionRowIndex].Gfxs[q].HookRot.ToString();
            ActionGfxScale.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxScale.ToString();
            ActionGfxAlpha.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxAlpha.ToString();
            ActionGfxSpeed.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxSpeed.ToString();
            ActionGfxOuterPath.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxOuterPath.ToString();
            ActionGfxRelToEcm.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxRelToECM.ToString();
            ActionGfxCustomPath.Text = ecm.Actions[ActionRowIndex].Gfxs[q].CustomPath.ToString();
            ActionGfxCustomData.Text = ecm.Actions[ActionRowIndex].Gfxs[q].CustomData.ToString();
            ActionGfxRotWithModel.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxRotWithModel.ToString();
            ActionGfxUseFixedPoint.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxUseFixedPoint.ToString();
            ActionGfxFxStartTime.Text = ecm.Actions[ActionRowIndex].Gfxs[q].FxStartTime.ToString();
            ActionGfxUseModelAlpha.Text = ecm.Actions[ActionRowIndex].Gfxs[q].UseModelAlpha.ToString();
            ActionGfxDelayTime.Text = ecm.Actions[ActionRowIndex].Gfxs[q].GfxDelayTime.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams.Count; i++)
            {
                ActionGfxParams.Rows.Add(ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams[i].ParamId,
                    ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams[i].ParamEleName,
                    ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams[i].ParamDataType,
                    ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams[i].ParamDataIsCmd,
                    ecm.Actions[ActionRowIndex].Gfxs[q].GfxParams[i].ParamDataHook);
            }
        }
        private void Version_Leave(object sender, EventArgs e)
        {
            if (ecm == null) return;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 1) ecm.Version = Version.Text.ToInt32();
            else if (n == 2) ecm.SmdPath = SmdPath.Text;
            else if (n == 3) ecm.AutoUpdata = AutoUpdata.Text.ToInt32();
            else if (n == 4) ecm.OrgColor = OrgColor.Text;
            else if (n == 5) ecm.EmissiveCol = EmmisiveCol.Text;
            else if (n == 6) ecm.SrcBlend = SrcBlend.Text.ToInt32();
            else if (n == 7) ecm.DestBlend = DestBlend.Text.ToInt32();
            else if (n == 8) ecm.DefSpeed = DefSpeed.Text.ToInt32();
            else if (n == 9) ecm.CanCastShadow = CanCastShadow.Text.ToInt32();
            else if (n == 10) ecm.RenderModel = RenderModel.Text.ToInt32();
            else if (n == 11) ecm.RenderEdge = RenderEdge.Text.ToInt32();
            else if (n == 12) ecm.PSFileVersion = PSFileVersion.Text.ToInt32();
            else if (n == 13) ecm.PSConstCount = PSConstCount.Text.ToInt32();
            else if (n == 14) ecm.ParticleBonesCount = ParticleBonesCount.Text.ToInt32();
            else if (n == 15) ecm.ShaderFile = ShaderFile.Text;
            else if (n == 16) ecm.ShaderTex = ShaderTex.Text;
            else if (n == 17) ecm.physfilename = PhysFileName.Text;
            else if (n == 18) ecm.ChannelCount = ChannelCount.Text.ToInt32();
            //  else if (n == 19) ecm.ChannelCount[1] = ChannelCount2.Text.ToInt32();
            else if (n == 20) ecm.NewScale = NewScale.Text.ToInt32();
        }
        private void BoneNum_Leave(object sender, EventArgs e)
        {
            if (Bones.CurrentRow == null) return;
            if (Bones.CurrentRow.Index == -1) return;
            int q = Bones.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 36) ecm.Bones[q].BoneIndex = BonesBoneIndex.Text.ToInt32();
            else if (n == 37) ecm.Bones[q].BoneSclType = BonesScaleType.Text.ToInt32();
            else if (n == 38) ecm.Bones[q].BoneScale[0] = BoneScaleX.Text.ToDecimal();
            else if (n == 39) ecm.Bones[q].BoneScale[1] = BoneScaleX.Text.ToDecimal();
            else if (n == 40) ecm.Bones[q].BoneScale[2] = BoneScaleX.Text.ToDecimal();
        }
        private void HookName_Leave(object sender, EventArgs e)
        {
            if (HooksGrid.CurrentRow == null) return;
            if (HooksGrid.CurrentRow.Index == -1) return;
            int q = HooksGrid.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 35) ecm.Hooks[q].Name = HookName.Text;
            else if (n == 21) ecm.Hooks[q].Id = HookId.Text.ToInt32();
            else if (n == 22) ecm.Hooks[q].Scale = HookScale.Text.ToInt32();
            else if (n == 23) ecm.Hooks[q].Hook1[0] = Hook1X.Text.ToDecimal();
            else if (n == 24) ecm.Hooks[q].Hook1[1] = Hook1Y.Text.ToDecimal();
            else if (n == 25) ecm.Hooks[q].Hook1[2] = Hook1Z.Text.ToDecimal();
            else if (n == 26) ecm.Hooks[q].Hook2[0] = Hook2X.Text.ToDecimal();
            else if (n == 27) ecm.Hooks[q].Hook2[1] = Hook2Y.Text.ToDecimal();
            else if (n == 28) ecm.Hooks[q].Hook2[2] = Hook2Z.Text.ToDecimal();
            else if (n == 29) ecm.Hooks[q].Hook3[0] = Hook3X.Text.ToDecimal();
            else if (n == 30) ecm.Hooks[q].Hook3[1] = Hook3Y.Text.ToDecimal();
            else if (n == 31) ecm.Hooks[q].Hook3[2] = Hook3Z.Text.ToDecimal();
            else if (n == 32) ecm.Hooks[q].Hook4[0] = Hook4X.Text.ToDecimal();
            else if (n == 33) ecm.Hooks[q].Hook4[1] = Hook4Y.Text.ToDecimal();
            else if (n == 34) ecm.Hooks[q].Hook4[2] = Hook4Z.Text.ToDecimal();
        }
        private void ActionSfxs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            ActionSfxFxFiles.Rows.Clear();
            if (ActionSfxs.CurrentRow == null) return;
            if (ActionSfxs.CurrentRow.Index == -1) return;
            int q = ActionSfxs.CurrentRow.Index;
            ActionsSfxPath.Text = ecm.Actions[ActionRowIndex].Sfx[q].FxFilePath;
            ActionSfxHookName.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookName;
            ActionSfxStartTime.Text = ecm.Actions[ActionRowIndex].Sfx[q].StartTime.ToString();
            ActionSfxTimeSpan.Text = ecm.Actions[ActionRowIndex].Sfx[q].TimeSpan.ToString();
            ActionSfxOnce.Text = ecm.Actions[ActionRowIndex].Sfx[q].Once.ToString();
            ActionSfxBindParent.Text = ecm.Actions[ActionRowIndex].Sfx[q].BindParent.ToString();
            ActionSfxFadeOut.Text = ecm.Actions[ActionRowIndex].Sfx[q].FadeOut.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Sfx[q].FxFiles.Count; i++)
            {
                ActionSfxFxFiles.Rows.Add(ecm.Actions[ActionRowIndex].Sfx[q].FxFiles[i]);
            }
            ActionSfxHookX.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookOffset[0].ToString();
            ActionSfxHookY.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookOffset[1].ToString();
            ActionSfxHookZ.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookOffset[2].ToString();
            ActionSfxYaw.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookYaw.ToString();
            ActionSfxPitch.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookPitch.ToString();
            ActionSfxRot.Text = ecm.Actions[ActionRowIndex].Sfx[q].HookRot.ToString();
            ActionSfxCustomPath.Text = ecm.Actions[ActionRowIndex].Sfx[q].CustomPath.ToString();
            ActionSfxCustomData.Text = ecm.Actions[ActionRowIndex].Sfx[q].CustomData.ToString();
            ActionSfxFxStartTime.Text = ecm.Actions[ActionRowIndex].Sfx[q].FxStartTime.ToString();
            ActionSfxUseModelAlpha.Text = ecm.Actions[ActionRowIndex].Sfx[q].UseModelAlpha.ToString();
            ActionSfxAbsoluteSound.Text = ecm.Actions[ActionRowIndex].Sfx[q].AbsoluteVolume.ToString();
            ActionSfxVolume.Text = ecm.Actions[ActionRowIndex].Sfx[q].Volume.ToString();
            ActionSfxVolMin.Text = ecm.Actions[ActionRowIndex].Sfx[q].VolMin.ToString();
            ActionSfxVolMax.Text = ecm.Actions[ActionRowIndex].Sfx[q].VolMax.ToString();
            ActionSfxMinDist.Text = ecm.Actions[ActionRowIndex].Sfx[q].MinDist.ToString();
            ActionSfxMaxDist.Text = ecm.Actions[ActionRowIndex].Sfx[q].MaxDist.ToString();
            ActionSfxForce2D.Text = ecm.Actions[ActionRowIndex].Sfx[q].Force2D.ToString();
            ActionSfxSoundVer.Text = ecm.Actions[ActionRowIndex].Sfx[q].SoundVer.ToString();
            ActionSfxIsLoop.Text = ecm.Actions[ActionRowIndex].Sfx[q].IsLoop.ToString();
            ActionSfxPitchMin.Text = ecm.Actions[ActionRowIndex].Sfx[q].PitchMin.ToString();
            ActionSfxPitchMax.Text = ecm.Actions[ActionRowIndex].Sfx[q].PitchMax.ToString();
            ActionSfxFixSpeed.Text = ecm.Actions[ActionRowIndex].Sfx[q].FixSpeed.ToString();
            ActionSfxSilentHeader.Text = ecm.Actions[ActionRowIndex].Sfx[q].SilentHeader.ToString();
            ActionSfxPercentStart.Text = ecm.Actions[ActionRowIndex].Sfx[q].PercentStart.ToString();
            ActionSfxGroup.Text = ecm.Actions[ActionRowIndex].Sfx[q].Group.ToString();
        }
        private void ActionAttacks_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ActionAttacks.CurrentRow == null) return;
            if (ActionAttacks.CurrentRow.Index == -1) return;
            int q = ActionAttacks.CurrentRow.Index;
            ActionAttackPath.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkPath;
            ActionAttackStartTime.Text = ecm.Actions[ActionRowIndex].Attacks[q].StartTime.ToString();
            ActionAttackTimeSpan.Text = ecm.Actions[ActionRowIndex].Attacks[q].TimeSpan.ToString();
            ActionAttackOnce.Text = ecm.Actions[ActionRowIndex].Attacks[q].Once.ToString();
            ActionAttackDivisions.Text = ecm.Actions[ActionRowIndex].Attacks[q].Divisions.ToString();
            ActionAttackAtkUseDelay.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkUseDelay.ToString();
            ActionAttackAtkOrient.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkOrient.ToString();
            ActionAttackAtkDelayNum.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkDelayNum.ToString();
            ActionAttackDelayTime1.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkDelayTime1.ToString();
            ActionAttackDelayTime2.Text = ecm.Actions[ActionRowIndex].Attacks[q].AtkDelayTime2.ToString();
        }
        private void ActionChilds_CurrentCellChanged(object sender, EventArgs e)
        {
            ActionChildSegments.Rows.Clear();
            if (ActionChilds.CurrentRow == null) return;
            if (ActionChilds.CurrentRow.Index == -1) return;
            int q = ActionChilds.CurrentRow.Index;
            ActionChildActName.Text = ecm.Actions[ActionRowIndex].ChildActs[q].ChildActName;
            ActionChildHHName.Text = ecm.Actions[ActionRowIndex].ChildActs[q].HHName;
            ActionChildStartTime.Text = ecm.Actions[ActionRowIndex].ChildActs[q].StartTime.ToString();
            ActionChildTimeSpan.Text = ecm.Actions[ActionRowIndex].ChildActs[q].TimeSpan.ToString();
            ActionChildOnce.Text = ecm.Actions[ActionRowIndex].ChildActs[q].Once.ToString();
            ActionChildIsIsTrail.Text = ecm.Actions[ActionRowIndex].ChildActs[q].IsTrail.ToString();
            ActionChildTrailSpan.Text = ecm.Actions[ActionRowIndex].ChildActs[q].TrailSpan.ToString();
            ActionChildTransTime.Text = ecm.Actions[ActionRowIndex].ChildActs[q].TransTime.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].ChildActs[q].Segs; i++)
            {
                ActionChildSegments.Rows.Add(
                     ecm.Actions[ActionRowIndex].ChildActs[q].Positions[i].X,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Positions[i].Y,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Positions[i].Z,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Directions[i].X,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Directions[i].Y,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Directions[i].Z,
                     ecm.Actions[ActionRowIndex].ChildActs[q].Directions[i].R);
            }
        }
        private void ActionColors_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ActionChilds.CurrentRow == null) return;
            if (ActionChilds.CurrentRow.Index == -1) return;
            int q = ActionChilds.CurrentRow.Index;
            ActionColorStartTime.Text = ecm.Actions[ActionRowIndex].Colors[q].StartTime.ToString();
            ActionColorTimeSpan.Text = ecm.Actions[ActionRowIndex].Colors[q].TimeSpan.ToString();
            ActionColorOnce.Text = ecm.Actions[ActionRowIndex].Colors[q].Once.ToString();
            ActionColor1A.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue1[0].ToString();
            ActionColor1R.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue1[1].ToString();
            ActionColor1G.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue1[2].ToString();
            ActionColor1B.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue1[3].ToString();
            ActionColor2A.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue2[0].ToString();
            ActionColor2R.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue2[1].ToString();
            ActionColor2G.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue2[2].ToString();
            ActionColor2B.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue2[3].ToString();
            ActionColor3A.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue3[0].ToString();
            ActionColor3R.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue3[1].ToString();
            ActionColor3G.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue3[2].ToString();
            ActionColor3B.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue3[3].ToString();
            ActionColor4A.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue4[0].ToString();
            ActionColor4R.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue4[1].ToString();
            ActionColor4G.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue4[2].ToString();
            ActionColor4B.Text = ecm.Actions[ActionRowIndex].Colors[q].ColorValue4[3].ToString();
        }
        private void ActionScripts_CurrentCellChanged(object sender, EventArgs e)
        {
            ActionScriptLines.Rows.Clear();
            if (ActionScripts.CurrentRow == null) return;
            if (ActionScripts.CurrentRow.Index == -1) return;
            int q = ActionScripts.CurrentRow.Index;
            ActionScriptStartTime.Text = ecm.Actions[ActionRowIndex].Scripts[q].StartTime.ToString();
            ActionScriptTimeSpan.Text = ecm.Actions[ActionRowIndex].Scripts[q].TimeSpan.ToString();
            ActionScriptOnce.Text = ecm.Actions[ActionRowIndex].Scripts[q].Once.ToString();
            ActionScriptCfgState.Text = ecm.Actions[ActionRowIndex].Scripts[q].ScriptCfgState.ToString();
            ActionScriptUsage.Text = ecm.Actions[ActionRowIndex].Scripts[q].ScriptUsage.ToString();
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Scripts[q].ScriptLines.Count + 1; i++)
            {
                ActionScriptLines.Rows.Add((object)i);
            }
        }
        private void ActionScriptLines_CurrentCellChanged(object sender, EventArgs e)
        {
            ActionScriptIn.Clear();
            ActionScriptTranslated.Clear();
            if (ActionScriptLines.CurrentRow == null) return;
            if (ActionScriptLines.CurrentRow.Index == -1) return;
            int q = ActionScriptLines.CurrentRow.Index;
            ActionScriptIn.Text = ecm.Actions[ActionRowIndex].Scripts[ActionScripts.CurrentRow.Index].ScriptLines[q];
            byte[] data = Convert.FromBase64String(ActionScriptIn.Text);
            ActionScriptTranslated.Text = Encoding.GetEncoding(1252).GetString(data);
        }
        private void Action107Types_CurrentCellChanged(object sender, EventArgs e)
        {
            Action107TypeScales.Rows.Clear();
            if (Action107Types.CurrentRow == null) return;
            if (Action107Types.CurrentRow.Index == -1) return;
            int q = Action107Types.CurrentRow.Index;
            Action107TypeStartTime.Text = ecm.Actions[ActionRowIndex].Type107s[q].StartTime.ToString();
            Action107TypeTimeSpan.Text = ecm.Actions[ActionRowIndex].Type107s[q].TimeSpan.ToString();
            Action107TypeOnce.Text = ecm.Actions[ActionRowIndex].Type107s[q].Once.ToString();
            Action107TypeUseFileScale.Text = ecm.Actions[ActionRowIndex].Type107s[q].Use_File_Scale.ToString();
            for (int i = 1; i < ecm.Actions[ActionRowIndex].Type107s[q].Scales.Count + 1; i++)
            {
                Action107TypeScales.Rows.Add((object)i);
            }
        }
        private void Action107TypeScales_CurrentCellChanged(object sender, EventArgs e)
        {
            Action107TypeScaleDests.Rows.Clear();
            if (Action107TypeScales.CurrentRow == null) return;
            if (Action107TypeScales.CurrentRow.Index == -1) return;
            int q = Action107TypeScales.CurrentRow.Index;
            Action107TypeScaleName.Text = ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].Name.ToString();
            Action107TypeScaleParam1.Text = ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclParam[0].ToString();
            Action107TypeScaleParam2.Text = ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclParam[1].ToString();
            Action107TypeScaleParam3.Text = ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclParam[2].ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclDest.Count; i++)
            {
                Action107TypeScaleDests.Rows.Add(ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclDest[i][0],
                    ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclDest[i][1],
                    ecm.Actions[ActionRowIndex].Type107s[Action107Types.CurrentRow.Index].Scales[q].SclDest[i][2]);
            }
        }
        private void Action108Types_CurrentCellChanged(object sender, EventArgs e)
        {
            Action108TypeDests.Rows.Clear();
            if (Action108Types.CurrentRow == null) return;
            if (Action108Types.CurrentRow.Index == -1) return;
            int q = Action108Types.CurrentRow.Index;
            Action108TypeStartTime.Text = ecm.Actions[ActionRowIndex].Type108s[q].StartTime.ToString();
            Action108TypeTimeSpan.Text = ecm.Actions[ActionRowIndex].Type108s[q].TimeSpan.ToString();
            Action108TypeOnce.Text = ecm.Actions[ActionRowIndex].Type108s[q].Once.ToString();
            Action108TypeCol.Text = ecm.Actions[ActionRowIndex].Type108s[q].Col.ToString();
            Action108TypeApplyChild.Text = ecm.Actions[ActionRowIndex].Type108s[q].ApplyChild.ToString();
            for (int i = 0; i < ecm.Actions[ActionRowIndex].Type108s[q].Dests.Count; i++)
            {
                Action108TypeDests.Rows.Add(ecm.Actions[ActionRowIndex].Type108s[q].Dests[i].Col,
                     ecm.Actions[ActionRowIndex].Type108s[q].Dests[i].Time);
            }
        }
        private void ChildsGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ChildsGrid.CurrentRow == null) return;
            if (ChildsGrid.CurrentRow.Index == -1) return;
            int q = ChildsGrid.CurrentRow.Index;
            ChildName.Text = ecm.Childs[q].ChildName;
            ChildPath.Text = ecm.Childs[q].ChildPath;
            ChildHHName.Text = ecm.Childs[q].HHName;
            ChildCCName.Text = ecm.Childs[q].CCName;
        }
        private void EndScripts_CurrentCellChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            if (EndScripts.CurrentRow == null) return;
            if (EndScripts.CurrentRow.Index == -1) return;
            int q = EndScripts.CurrentRow.Index;
            for (int i = 0; i < ecm.Scripts[q].ScriptLines.Count; i++)
            {
                richTextBox2.AppendText(ecm.Scripts[q].ScriptLines[i] + "\n");
            }
            byte[] data = Convert.FromBase64String(richTextBox2.Text);
            richTextBox1.Text = Encoding.GetEncoding(936).GetString(data);
        }
        private void Channels_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ecm.ChannelMask[e.RowIndex] = Channels.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
        }
        private void AudioEventGroupEnableGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ecm.AudioEventGroupEnable[e.RowIndex] = AudioEventGroupEnableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
        }
        private void OuterNumValues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ecm.Outers[e.RowIndex] = OuterNumValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
        }
        private void ChildHHName_Leave(object sender, EventArgs e)
        {
            if (ChildsGrid.CurrentRow == null) return;
            if (ChildsGrid.CurrentRow.Index == -1) return;
            int q = ChildsGrid.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 41) ecm.Childs[q].ChildName = ChildName.Text;
            else if (n == 42) ecm.Childs[q].ChildPath = ChildPath.Text;
            else if (n == 43) ecm.Childs[q].HHName = ChildHHName.Text;
            else if (n == 44) ecm.Childs[q].CCName = ChildCCName.Text;
        }
        private void AddiSkins_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ecm.AddiSkins[e.RowIndex] = AddiSkins.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
        private void DGfxPath_Leave(object sender, EventArgs e)
        {
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            int q = Gfxs.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 45) ecm.Gfxs[q].FxFilePath = DGfxPath.Text;
            else if (n == 46) ecm.Gfxs[q].HookName = DGfxHookName.Text;
            else if (n == 47) ecm.Gfxs[q].StartTime = DGfxStartTime.Text.ToInt32();
            else if (n == 48) ecm.Gfxs[q].TimeSpan = DGfxTimeSpan.Text.ToInt32();
            else if (n == 49) ecm.Gfxs[q].Once = DGfxOnce.Text.ToInt32();
            else if (n == 50) ecm.Gfxs[q].BindParent = DGfxBindParent.Text.ToInt32();
            else if (n == 51) ecm.Gfxs[q].FadeOut = DGfxFadeOut.Text.ToInt32();
            else if (n == 52) ecm.Gfxs[q].HookOffset[0] = DGfxHookX.Text.ToDecimal();
            else if (n == 53) ecm.Gfxs[q].HookOffset[1] = DGfxHookY.Text.ToDecimal();
            else if (n == 54) ecm.Gfxs[q].HookOffset[2] = DGfxHookZ.Text.ToDecimal();
            else if (n == 55) ecm.Gfxs[q].HookYaw = DGfxHookYaw.Text.ToDecimal();
            else if (n == 56) ecm.Gfxs[q].HookPitch = DGfxHookPitch.Text.ToInt32();
            else if (n == 57) ecm.Gfxs[q].HookRot = DGfxTimeSpan.Text.ToInt32();
            else if (n == 58) ecm.Gfxs[q].GfxScale = DGfxScale.Text.ToDecimal();
            else if (n == 59) ecm.Gfxs[q].GfxAlpha = DGfxAlpha.Text.ToDecimal();
            else if (n == 60) ecm.Gfxs[q].GfxSpeed = DGfxSpeed.Text.ToDecimal();
            else if (n == 61) ecm.Gfxs[q].GfxOuterPath = DGfxOuterPath.Text.ToInt32();
            else if (n == 62) ecm.Gfxs[q].GfxRelToECM = DGfxRelToECM.Text.ToInt32();
            else if (n == 63) ecm.Gfxs[q].CustomPath = DGfxCustomPath.Text.ToInt32();
            else if (n == 64) ecm.Gfxs[q].CustomData = DGfxCustomData.Text.ToInt32();
            else if (n == 65) ecm.Gfxs[q].GfxRotWithModel = DGfxRotWithModel.Text.ToInt32();
            else if (n == 66) ecm.Gfxs[q].GfxUseFixedPoint = DGfxUseFixedPoint.Text.ToInt32();
            else if (n == 67) ecm.Gfxs[q].FxStartTime = DGfxFxStartTime.Text.ToInt32();
            else if (n == 68) ecm.Gfxs[q].UseModelAlpha = DGfxUseModelalpha.Text.ToInt32();
            else if (n == 69) ecm.Gfxs[q].GfxDelayTime = DGfxDelayTime.Text.ToInt32();
        }
        private void DGfxFxFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            int q = Gfxs.CurrentRow.Index;
            ecm.Gfxs[q].FxFiles[e.RowIndex] = DGfxFxFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
        private void DGfxParams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            int q = Gfxs.CurrentRow.Index;
            switch (e.RowIndex)
            {
                case 0:
                    {
                        ecm.Gfxs[q].GfxParams[e.RowIndex].ParamId = DGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 1:
                    {
                        ecm.Gfxs[q].GfxParams[e.RowIndex].ParamEleName = DGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        break;
                    }
                case 2:
                    {
                        ecm.Gfxs[q].GfxParams[e.RowIndex].ParamDataType = DGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 3:
                    {
                        ecm.Gfxs[q].GfxParams[e.RowIndex].ParamDataIsCmd = DGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 4:
                    {
                        ecm.Gfxs[q].GfxParams[e.RowIndex].ParamDataHook = DGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        break;
                    }
            }
        }
        private void textBoxWithButton1_Button_MouseEnter(object sender, EventArgs e)
        {
            OpenEcm.Image = Properties.Resources.Enter;
        }
        private void textBoxWithButton1_Button_MouseLeave(object sender, EventArgs e)
        {
            OpenEcm.Image = Properties.Resources.Default;
        }
        private void ActionResetMtl_Leave(object sender, EventArgs e)
        {
            if (Combine == null) return;
            Combine.Hide();
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 70)
            {
                ecm.Actions[q].CombineActName = CombineActName.Text;
                Actions.Rows[q].Cells[0].Value = CombineActName.Text;
            }
            else if (n == 71) ecm.Actions[q].LoopCount = ActionLoopCount.Text.ToInt32();
            else if (n == 72) ecm.Actions[q].EventChannel = ActionEventChannel.Text.ToInt32();
            else if (n == 73) ecm.Actions[q].PlaySpeed = ActionPlaySpeed.Text.ToDecimal();
            else if (n == 74) ecm.Actions[q].StopChildAct = ActionStopChildAct.Text.ToInt32();
            else if (n == 75) ecm.Actions[q].ResetMtl = ActionResetMtl.Text.ToInt32();
        }
        private void ActionRanks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            if (e.ColumnIndex == 0)
                ecm.Actions[q].Ranks[e.RowIndex].Channel = ActionRanks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
            else
                ecm.Actions[q].Ranks[e.RowIndex].RankT = ActionRanks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();

        }
        private void BaseActName_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || BaseActions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || BaseActions.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int l = BaseActions.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 76)
            {
                ecm.Actions[q].BaseActions[l].BaseActName = BaseActName.Text;
                BaseActions.CurrentRow.Cells[0].Value = BaseActName.Text;
            }
            else if (n == 77) ecm.Actions[q].BaseActions[l].ActStartTime = BaseActStartTime.Text.ToInt32();
            else if (n == 78) ecm.Actions[q].BaseActions[l].LoopCount = BaseActLoopCount.Text.ToInt32();
            else if (n == 79) ecm.Actions[q].BaseActions[l].LoopMinNum = BaseActLoopMinNum.Text.ToInt32();
            else if (n == 80) ecm.Actions[q].BaseActions[l].LoopMaxNum = BaseActLoopMaxNum.Text.ToInt32();
        }
        private void OpenSmd_Button_MouseEnter(object sender, EventArgs e)
        {
            OpenSmd.Image = Properties.Resources.Enter;
        }
        private void OpenSmd_Button_MouseLeave(object sender, EventArgs e)
        {
            OpenSmd.Image = Properties.Resources.Default;
        }
        private void OpenSmd_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Smd File";
            ofd.Filter = "Smd Files|*.smd|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                smd = new SmdFile(ofd.FileName);
                OpenSmd.TextBoxText = ofd.FileName;
                Dictionary<string, string> Dict = new Dictionary<string, string>();
                Task[] tasks = new Task[smd.Actions.Count];
                int i = 0;
                string eg = comboBox1.SelectedItem.ToString();
                foreach (var item in smd.Actions)
                {
                    tasks[i] = new Task(new System.Action(() =>
                      {
                          string f = Translate(item.ActionName, "zh-CHS", eg);
                          Dict.Add(item.ActionName, f);
                      }));
                    i++;
                }
                foreach (var item in tasks)
                {
                    item.Start();
                }
                Task.WaitAll(tasks);
                lcombobox = new LCombobox(Dict, BaseActName, this);
            }
        }
        private void BaseActNameTranslated_Enter(object sender, EventArgs e)
        {
            if (lcombobox == null) return;
            lcombobox.Show(this);
            var eg = BaseActName.PointToScreen(Point.Empty);
            lcombobox.Bounds = new Rectangle(eg.X, eg.Y + 60, lcombobox.Width, lcombobox.Height);

        }
        private void BaseActNameTranslated_Leave(object sender, EventArgs e)
        {
            if (lcombobox == null) return;
            lcombobox.Hide();
        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (lcombobox == null || lcombobox?.Visible == false) return;
            var eg = BaseActName.PointToScreen(Point.Empty);
            lcombobox.Bounds = new Rectangle(eg.X, eg.Y + 60, lcombobox.Width, lcombobox.Height);
        }
        private void ActionsGfxPath_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || ActionGfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionGfxs.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionGfxs.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 81) ecm.Actions[q].Gfxs[t].FxFilePath = ActionsGfxPath.Text;
            else if (n == 82) ecm.Actions[q].Gfxs[t].HookName = ActionsGfxHookName.Text;
            else if (n == 83) ecm.Actions[q].Gfxs[t].StartTime = ActionsGfxStartTime.Text.ToInt32();
            else if (n == 84) ecm.Actions[q].Gfxs[t].TimeSpan = ActionsGfxTimeSpan.Text.ToInt32();
            else if (n == 85) ecm.Actions[q].Gfxs[t].Once = ActionsGfxOnce.Text.ToInt32();
            else if (n == 86) ecm.Actions[q].Gfxs[t].BindParent = ActionsGfxBindParent.Text.ToInt32();
            else if (n == 87) ecm.Actions[q].Gfxs[t].FadeOut = ActionsGfxFadeOut.Text.ToInt32();
            else if (n == 88) ecm.Actions[q].Gfxs[t].HookOffset[0] = ActionGfxHookX.Text.ToDecimal();
            else if (n == 89) ecm.Actions[q].Gfxs[t].HookOffset[1] = ActionGfxHookY.Text.ToDecimal();
            else if (n == 90) ecm.Actions[q].Gfxs[t].HookOffset[2] = ActionGfxHookZ.Text.ToDecimal();
            else if (n == 91) ecm.Actions[q].Gfxs[t].HookYaw = ActionGfxHookYaw.Text.ToDecimal();
            else if (n == 92) ecm.Actions[q].Gfxs[t].HookPitch = ActionGfxHookPitch.Text.ToInt32();
            else if (n == 93) ecm.Actions[q].Gfxs[t].HookRot = ActionGfxRot.Text.ToInt32();
            else if (n == 94) ecm.Actions[q].Gfxs[t].GfxScale = ActionGfxScale.Text.ToDecimal();
            else if (n == 95) ecm.Actions[q].Gfxs[t].GfxAlpha = ActionGfxAlpha.Text.ToDecimal();
            else if (n == 96) ecm.Actions[q].Gfxs[t].GfxSpeed = ActionGfxSpeed.Text.ToDecimal();
            else if (n == 97) ecm.Actions[q].Gfxs[t].GfxOuterPath = ActionGfxOuterPath.Text.ToInt32();
            else if (n == 98) ecm.Actions[q].Gfxs[t].GfxRelToECM = ActionGfxRelToEcm.Text.ToInt32();
            else if (n == 99) ecm.Actions[q].Gfxs[t].CustomPath = ActionGfxCustomPath.Text.ToInt32();
            else if (n == 100) ecm.Actions[q].Gfxs[t].CustomData = ActionGfxCustomData.Text.ToInt32();
            else if (n == 101) ecm.Actions[q].Gfxs[t].GfxRotWithModel = ActionGfxRotWithModel.Text.ToInt32();
            else if (n == 102) ecm.Actions[q].Gfxs[t].GfxUseFixedPoint = ActionGfxUseFixedPoint.Text.ToInt32();
            else if (n == 103) ecm.Actions[q].Gfxs[t].FxStartTime = ActionGfxFxStartTime.Text.ToInt32();
            else if (n == 104) ecm.Actions[q].Gfxs[t].UseModelAlpha = ActionGfxUseModelAlpha.Text.ToInt32();
            else if (n == 105) ecm.Actions[q].Gfxs[t].GfxDelayTime = ActionGfxDelayTime.Text.ToInt32();
        }
        private void ActionGfxParams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null && ActionGfxs.CurrentRow != null) return;
            if (Actions.CurrentRow.Index == -1 && ActionGfxs.CurrentRow.Index != -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionGfxs.CurrentRow.Index;
            switch (e.RowIndex)
            {
                case 0:
                    {
                        ecm.Actions[q].Gfxs[t].GfxParams[e.RowIndex].ParamId = ActionGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 1:
                    {
                        ecm.Actions[q].Gfxs[t].GfxParams[e.RowIndex].ParamEleName = ActionGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        break;
                    }
                case 2:
                    {
                        ecm.Actions[q].Gfxs[t].GfxParams[e.RowIndex].ParamDataType = ActionGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 3:
                    {
                        ecm.Actions[q].Gfxs[t].GfxParams[e.RowIndex].ParamDataIsCmd = ActionGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                        break;
                    }
                case 4:
                    {
                        ecm.Actions[q].Gfxs[t].GfxParams[e.RowIndex].ParamDataHook = ActionGfxParams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        break;
                    }
            }
        }
        private void ActionsSfxPath_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null && ActionSfxs.CurrentRow != null) return;
            if (Actions.CurrentRow.Index == -1 && ActionSfxs.CurrentRow.Index != -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionSfxs.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 106) ecm.Actions[q].Sfx[t].FxFilePath = ActionsSfxPath.Text;
            else if (n == 107) ecm.Actions[q].Sfx[t].HookName = ActionSfxHookName.Text;
            else if (n == 108) ecm.Actions[q].Sfx[t].SoundVer = ActionSfxSoundVer.Text.ToInt32();
            else if (n == 109) ecm.Actions[q].Sfx[t].StartTime = ActionSfxStartTime.Text.ToInt32();
            else if (n == 110) ecm.Actions[q].Sfx[t].TimeSpan = ActionSfxTimeSpan.Text.ToInt32();
            else if (n == 111) ecm.Actions[q].Sfx[t].Once = ActionSfxOnce.Text.ToInt32();
            else if (n == 112) ecm.Actions[q].Sfx[t].BindParent = ActionSfxBindParent.Text.ToInt32();
            else if (n == 113) ecm.Actions[q].Sfx[t].FadeOut = ActionSfxFadeOut.Text.ToInt32();
            else if (n == 114) ecm.Actions[q].Sfx[t].HookOffset[0] = ActionSfxHookX.Text.ToDecimal();
            else if (n == 115) ecm.Actions[q].Sfx[t].HookOffset[1] = ActionSfxHookY.Text.ToDecimal();
            else if (n == 116) ecm.Actions[q].Sfx[t].HookOffset[2] = ActionSfxHookZ.Text.ToDecimal();
            else if (n == 117) ecm.Actions[q].Sfx[t].HookYaw = ActionSfxYaw.Text.ToDecimal();
            else if (n == 118) ecm.Actions[q].Sfx[t].HookPitch = ActionSfxPitch.Text.ToDecimal();
            else if (n == 119) ecm.Actions[q].Sfx[t].HookRot = ActionSfxRot.Text.ToDecimal();
            else if (n == 120) ecm.Actions[q].Sfx[t].Force2D = ActionSfxForce2D.Text.ToInt32();
            else if (n == 121) ecm.Actions[q].Sfx[t].IsLoop = ActionSfxIsLoop.Text.ToInt32();
            else if (n == 122) ecm.Actions[q].Sfx[t].AbsoluteVolume = ActionSfxAbsoluteSound.Text.ToInt32();
            else if (n == 123) ecm.Actions[q].Sfx[t].Volume = ActionSfxVolume.Text.ToInt32();
            else if (n == 124) ecm.Actions[q].Sfx[t].VolMin = ActionSfxVolMin.Text.ToInt32();
            else if (n == 125) ecm.Actions[q].Sfx[t].VolMax = ActionSfxVolMax.Text.ToInt32();
            else if (n == 126) ecm.Actions[q].Sfx[t].MinDist = ActionSfxMinDist.Text.ToDecimal();
            else if (n == 127) ecm.Actions[q].Sfx[t].MaxDist = ActionSfxMaxDist.Text.ToDecimal();
            else if (n == 128) ecm.Actions[q].Sfx[t].CustomPath = ActionSfxCustomPath.Text.ToInt32();
            else if (n == 129) ecm.Actions[q].Sfx[t].CustomData = ActionSfxCustomData.Text.ToInt32();
            else if (n == 130) ecm.Actions[q].Sfx[t].PitchMin = ActionSfxPitchMin.Text.ToDecimal();
            else if (n == 131) ecm.Actions[q].Sfx[t].PitchMax = ActionSfxPitchMax.Text.ToDecimal();
            else if (n == 132) ecm.Actions[q].Sfx[t].UseModelAlpha = ActionSfxUseModelAlpha.Text.ToInt32();
            else if (n == 133) ecm.Actions[q].Sfx[t].FixSpeed = ActionSfxFixSpeed.Text.ToInt32();
            else if (n == 134) ecm.Actions[q].Sfx[t].SilentHeader = ActionSfxSilentHeader.Text.ToInt32();
            else if (n == 135) ecm.Actions[q].Sfx[t].PercentStart = ActionSfxPercentStart.Text.ToDecimal();
            else if (n == 136) ecm.Actions[q].Sfx[t].Group = ActionSfxGroup.Text.ToInt32();
            else if (n == 137) ecm.Actions[q].Sfx[t].FxStartTime = ActionSfxFxStartTime.Text.ToInt32();

        }
        private void ActionSfxFxFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null || ActionSfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionSfxs.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionSfxs.CurrentRow.Index;
            ecm.Actions[q].Sfx[t].FxFiles[e.RowIndex] = ActionSfxFxFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

        }
        private void ActionsGfxFxFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null || ActionGfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionGfxs.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionGfxs.CurrentRow.Index;
            ecm.Actions[q].Gfxs[t].FxFiles[e.RowIndex] = ActionsGfxFxFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
        private void ActionChildActName_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null && ActionChilds.CurrentRow != null) return;
            if (Actions.CurrentRow.Index == -1 && ActionChilds.CurrentRow.Index != -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionChilds.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 138) ecm.Actions[q].ChildActs[t].ChildActName = ActionChildActName.Text;
            else if (n == 139) ecm.Actions[q].ChildActs[t].HHName = ActionChildHHName.Text;
            else if (n == 140) ecm.Actions[q].ChildActs[t].StartTime = ActionChildStartTime.Text.ToInt32();
            else if (n == 141) ecm.Actions[q].ChildActs[t].TimeSpan = ActionChildTimeSpan.Text.ToInt32();
            else if (n == 142) ecm.Actions[q].ChildActs[t].Once = ActionChildOnce.Text.ToInt32();
            else if (n == 143) ecm.Actions[q].ChildActs[t].IsTrail = ActionChildIsIsTrail.Text.ToInt32();
            else if (n == 144) ecm.Actions[q].ChildActs[t].TrailSpan = ActionChildTrailSpan.Text.ToInt32();
            else if (n == 194) ecm.Actions[q].ChildActs[t].TransTime = ActionChildTransTime.Text.ToInt32();

        }
        private void ActionChildSegments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null || ActionChilds.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionChilds.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionChilds.CurrentRow.Index;
            switch (e.ColumnIndex)
            {
                case 0:
                    ecm.Actions[q].ChildActs[t].Positions[e.RowIndex].X = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 1:
                    ecm.Actions[q].ChildActs[t].Positions[e.RowIndex].Y = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 2:
                    ecm.Actions[q].ChildActs[t].Positions[e.RowIndex].Z = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 3:
                    ecm.Actions[q].ChildActs[t].Directions[e.RowIndex].X = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 4:
                    ecm.Actions[q].ChildActs[t].Directions[e.RowIndex].Y = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 5:
                    ecm.Actions[q].ChildActs[t].Directions[e.RowIndex].Z = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 6:
                    ecm.Actions[q].ChildActs[t].Directions[e.RowIndex].R = ActionChildSegments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
            }
        }
        private void ActionColorStartTime_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null && ActionColors.CurrentRow != null) return;
            if (Actions.CurrentRow.Index == -1 && ActionColors.CurrentRow.Index != -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionColors.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 145) ecm.Actions[q].Colors[t].StartTime = ActionColorStartTime.Text.ToInt32();
            else if (n == 146) ecm.Actions[q].Colors[t].TimeSpan = ActionColorTimeSpan.Text.ToInt32();
            else if (n == 147) ecm.Actions[q].Colors[t].Once = ActionColorOnce.Text.ToInt32();
            else if (n == 148) ecm.Actions[q].Colors[t].ColorValue1[0] = ActionColor1A.Text.ToInt32();
            else if (n == 149) ecm.Actions[q].Colors[t].ColorValue1[1] = ActionColor1R.Text.ToInt32();
            else if (n == 150) ecm.Actions[q].Colors[t].ColorValue1[2] = ActionColor1G.Text.ToInt32();
            else if (n == 151) ecm.Actions[q].Colors[t].ColorValue1[3] = ActionColor1B.Text.ToInt32();
            else if (n == 152) ecm.Actions[q].Colors[t].ColorValue2[0] = ActionColor2A.Text.ToInt32();
            else if (n == 153) ecm.Actions[q].Colors[t].ColorValue2[1] = ActionColor2R.Text.ToInt32();
            else if (n == 154) ecm.Actions[q].Colors[t].ColorValue2[2] = ActionColor2G.Text.ToInt32();
            else if (n == 155) ecm.Actions[q].Colors[t].ColorValue2[3] = ActionColor2B.Text.ToInt32();
            else if (n == 156) ecm.Actions[q].Colors[t].ColorValue3[0] = ActionColor3A.Text.ToInt32();
            else if (n == 157) ecm.Actions[q].Colors[t].ColorValue3[1] = ActionColor3R.Text.ToInt32();
            else if (n == 158) ecm.Actions[q].Colors[t].ColorValue3[2] = ActionColor3G.Text.ToInt32();
            else if (n == 159) ecm.Actions[q].Colors[t].ColorValue3[3] = ActionColor3B.Text.ToInt32();
            else if (n == 160) ecm.Actions[q].Colors[t].ColorValue4[0] = ActionColor4A.Text.ToInt32();
            else if (n == 161) ecm.Actions[q].Colors[t].ColorValue4[1] = ActionColor4R.Text.ToInt32();
            else if (n == 162) ecm.Actions[q].Colors[t].ColorValue4[2] = ActionColor4G.Text.ToInt32();
            else if (n == 163) ecm.Actions[q].Colors[t].ColorValue4[3] = ActionColor4B.Text.ToInt32();
        }
        private void ActionAttackPath_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null && ActionAttacks.CurrentRow != null) return;
            if (Actions.CurrentRow.Index == -1 && ActionAttacks.CurrentRow.Index != -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionAttacks.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 164) ecm.Actions[q].Attacks[t].AtkPath = ActionAttackPath.Text;
            else if (n == 165) ecm.Actions[q].Attacks[t].StartTime = ActionAttackStartTime.Text.ToInt32();
            else if (n == 166) ecm.Actions[q].Attacks[t].TimeSpan = ActionAttackTimeSpan.Text.ToInt32();
            else if (n == 167) ecm.Actions[q].Attacks[t].Once = ActionAttackOnce.Text.ToInt32();
            else if (n == 168) ecm.Actions[q].Attacks[t].Divisions = ActionAttackDivisions.Text.ToInt32();
            else if (n == 169) ecm.Actions[q].Attacks[t].AtkUseDelay = ActionAttackAtkUseDelay.Text.ToInt32();
            else if (n == 170) ecm.Actions[q].Attacks[t].AtkOrient = ActionAttackAtkOrient.Text.ToInt32();
            else if (n == 171) ecm.Actions[q].Attacks[t].AtkDelayNum = ActionAttackAtkDelayNum.Text.ToInt32();
            else if (n == 172) ecm.Actions[q].Attacks[t].AtkDelayTime1 = ActionAttackDelayTime1.Text.ToInt32();
            else if (n == 173) ecm.Actions[q].Attacks[t].AtkDelayTime2 = ActionAttackDelayTime2.Text.ToInt32();
        }
        private void ActionScriptUsage_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || ActionScripts.CurrentRow == null || ActionScriptLines.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionScripts.CurrentRow.Index == -1 || ActionScriptLines.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = ActionScripts.CurrentRow.Index;
            int l = ActionScriptLines.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 174) ecm.Actions[q].Scripts[t].StartTime = ActionScriptStartTime.Text.ToInt32();
            else if (n == 175) ecm.Actions[q].Scripts[t].TimeSpan = ActionScriptTimeSpan.Text.ToInt32();
            else if (n == 176) ecm.Actions[q].Scripts[t].Once = ActionScriptOnce.Text.ToInt32();
            else if (n == 177) ecm.Actions[q].Scripts[t].ScriptCfgState = ActionScriptCfgState.Text.ToInt32();
            else if (n == 178) ecm.Actions[q].Scripts[t].ScriptUsage = ActionScriptUsage.Text.ToInt32();
            else if (n == 179) ecm.Actions[q].Scripts[t].ScriptLines[l] = ActionScriptIn.Text;
            else if (n == 180)
            {
                ActionScriptIn.Text = Convert.ToBase64String(Encoding.GetEncoding(1252).GetBytes(ActionScriptTranslated.Text));
                ecm.Actions[q].Scripts[t].ScriptLines[l] = Convert.ToBase64String(Encoding.GetEncoding(1252).GetBytes(ActionScriptTranslated.Text));
            }
        }
        private void Action107TypeStartTime_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || Action107Types.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || Action107Types.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = Action107Types.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 181) ecm.Actions[q].Type107s[t].StartTime = Action107TypeStartTime.Text.ToInt32();
            else if (n == 182) ecm.Actions[q].Type107s[t].TimeSpan = Action107TypeTimeSpan.Text.ToInt32();
            else if (n == 183) ecm.Actions[q].Type107s[t].Once = Action107TypeOnce.Text.ToInt32();
            else if (n == 184) ecm.Actions[q].Type107s[t].Use_File_Scale = Action107TypeUseFileScale.Text.ToInt32();
        }
        private void Action107TypeScaleName_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || Action107Types.CurrentRow == null || Action107TypeScales.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || Action107Types.CurrentRow.Index == -1 || Action107TypeScales.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = Action107Types.CurrentRow.Index;
            int l = Action107TypeScales.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 185) ecm.Actions[q].Type107s[t].Scales[l].Name = Action107TypeScaleName.Text;
            else if (n == 186) ecm.Actions[q].Type107s[t].Scales[l].SclParam[0] = Action107TypeScaleParam1.Text.ToDecimal();
            else if (n == 187) ecm.Actions[q].Type107s[t].Scales[l].SclParam[1] = Action107TypeScaleParam2.Text.ToDecimal();
            else if (n == 188) ecm.Actions[q].Type107s[t].Scales[l].SclParam[2] = Action107TypeScaleParam3.Text.ToDecimal();
        }
        private void Action107TypeScaleDests_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null || Action107Types.CurrentRow == null || Action107TypeScales.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || Action107Types.CurrentRow.Index == -1 || Action107TypeScales.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = Action107Types.CurrentRow.Index;
            int l = Action107TypeScales.CurrentRow.Index;
            switch (e.ColumnIndex)
            {
                case 0:
                    ecm.Actions[q].Type107s[t].Scales[l].SclDest[e.RowIndex][0] = Action107TypeScaleDests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 1:
                    ecm.Actions[q].Type107s[t].Scales[l].SclDest[e.RowIndex][1] = Action107TypeScaleDests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
                case 2:
                    ecm.Actions[q].Type107s[t].Scales[l].SclDest[e.RowIndex][2] = Action107TypeScaleDests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToDecimal();
                    break;
            }
        }
        private void Action108TypeApplyChild_Leave(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || Action108Types.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || Action108Types.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = Action108Types.CurrentRow.Index;
            int n = Convert.ToInt32((sender as Control).Tag);
            if (n == 189) ecm.Actions[q].Type108s[t].StartTime = Action108TypeStartTime.Text.ToInt32();
            else if (n == 190) ecm.Actions[q].Type108s[t].TimeSpan = Action108TypeTimeSpan.Text.ToInt32();
            else if (n == 191) ecm.Actions[q].Type108s[t].Once = Action108TypeOnce.Text.ToInt32();
            else if (n == 192) ecm.Actions[q].Type108s[t].Col = Action108TypeCol.Text.ToInt32();
            else if (n == 193) ecm.Actions[q].Type108s[t].ApplyChild = Action108TypeApplyChild.Text.ToInt32();
        }
        private void Action108TypeDests_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Actions.CurrentRow == null || Action108Types.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || Action108Types.CurrentRow.Index == -1) return;
            int q = Actions.CurrentRow.Index;
            int t = Action108Types.CurrentRow.Index;
            switch (e.ColumnIndex)
            {
                case 0:
                    ecm.Actions[q].Type108s[t].Dests[e.RowIndex].Col = Action108TypeDests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                    break;
                case 1:
                    ecm.Actions[q].Type108s[t].Dests[e.RowIndex].Time = Action108TypeDests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToInt32();
                    break;
            }
        }
        public void RaiseCombineTextBoxLeft(string Name)
        {
            if (Name == "CombineActName")
            {
                ActionResetMtl_Leave(CombineActName, null);
            }
            else
            {
                BaseActName_Leave(BaseActName, null);
            }
        }

        private void DeleteAction_Click(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            var indexes = Actions.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderByDescending(f => f).ToList();
            foreach (var item in indexes)
            {
                Actions.Rows.RemoveAt(item);
                ecm.Actions.RemoveAt(item);
                ecm.ComActCount--;
            }
        }

        private void CloneAction_Click(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            var indexes = Actions.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderBy(f => f).ToList();
            foreach (var item in indexes)
            {
                MemoryStream st = new MemoryStream();
                st.Position = 0;
                StreamWriter sw = new StreamWriter(st);
                ecm.Actions[item].Save(sw, ecm.Version);
                sw.Flush();
                st.Seek(0, SeekOrigin.Begin);
                ecm.Actions.Add(new Action(new StreamReader(st), ecm.Version));
                ecm.ComActCount++;
                Actions.Rows.Add(ecm.Actions.Last().CombineActName);
            }
            Actions.CurrentCell = Actions.Rows[Actions.Rows.Count - 1].Cells[0];
        }

        private void CombineActName_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Combine == null) return;
                Combine.Show(this);
            }
            catch
            {
                Combine = new ActionList(CombineActName, this);
                Combine.Show(this);
            }
        }

        private void CopyActionGfx_Click(object sender, EventArgs e)
        {
            if (ActionGfxs.CurrentRow == null) return;
            if (ActionGfxs.CurrentRow.Index == -1) return;
            MemoryStream st = new MemoryStream();
            st.Position = 0;
            StreamWriter sw = new StreamWriter(st);
            ecm.Actions[Actions.CurrentRow.Index].Gfxs[ActionGfxs.CurrentRow.Index].Save(sw, ecm.Version);
            sw.Flush();
            st.Seek(0, SeekOrigin.Begin);
            Clipboard.SetText(new StreamReader(st).ReadToEnd());
        }
        public static Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        private void PasteActionGfx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actions.CurrentRow == null) return;
                if (Actions.CurrentRow.Index == -1) return;
                ecm.Actions[Actions.CurrentRow.Index].Gfxs.Add(new Gfx(new StreamReader(GenerateStreamFromString(Clipboard.GetText()), Encoding.UTF8), ecm.Version, true));
                ecm.Actions[Actions.CurrentRow.Index].EventCount++;
                ActionGfxs.Rows.Add((object)(ActionGfxs.Rows.Count + 1));
                ActionEventCount.Text = ecm.Actions[Actions.CurrentRow.Index].EventCount.ToString();
            }
            catch
            {

            }
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            if (ecm != null)
            {
                ecm.Fix();
            }
        }

        private void DeleteActionGfx_Click(object sender, EventArgs e)
        {

            if (Actions.CurrentRow == null || ActionGfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionGfxs.CurrentRow.Index == -1) return;
            int actindex = Actions.CurrentRow.Index;
            var indexes = ActionGfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderByDescending(f => f).ToList();
            foreach (var item in indexes)
            {
                ActionGfxs.Rows.RemoveAt(item);
                ecm.Actions[actindex].Gfxs.RemoveAt(item);
                ecm.Actions[actindex].EventCount--;
            }
        }

        private void CloneGfx_Click(object sender, EventArgs e)
        {
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            var indexes = Gfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderBy(f => f).ToList();
            foreach (var item in indexes)
            {
                MemoryStream st = new MemoryStream();
                st.Position = 0;
                StreamWriter sw = new StreamWriter(st);
                ecm.Gfxs[item].Save(sw, ecm.Version);
                sw.Flush();
                st.Seek(0, SeekOrigin.Begin);
                ecm.Gfxs.Add(new Gfx(new StreamReader(st), ecm.Version, true));
                Gfxs.Rows.Add(Gfxs.Rows.Count);
            }
            Gfxs.CurrentCell = Gfxs.Rows[Gfxs.Rows.Count - 1].Cells[0];
        }

        private void DeleteGfx_Click(object sender, EventArgs e)
        {
            if (Gfxs.CurrentRow == null) return;
            if (Gfxs.CurrentRow.Index == -1) return;
            var indexes = Gfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderByDescending(f => f).ToList();
            foreach (var item in indexes)
            {
                Gfxs.Rows.RemoveAt(item);
                ecm.Gfxs.RemoveAt(item);
            }
        }

        private void CloneActionGfx_Click(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1) return;
            if (ActionGfxs.CurrentRow != null && ActionGfxs.CurrentRow?.Index != -1)
            {
                int ind = Actions.CurrentRow.Index;
                var indexes = ActionGfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderBy(f => f).ToList();
                foreach (var item in indexes)
                {
                    MemoryStream st = new MemoryStream();
                    st.Position = 0;
                    StreamWriter sw = new StreamWriter(st);
                    ecm.Actions[ind].Gfxs[item].Save(sw, ecm.Version);
                    sw.Flush();
                    st.Seek(0, SeekOrigin.Begin);
                    ecm.Actions[ind].Gfxs.Add(new Gfx(new StreamReader(st), ecm.Version, true));
                    ActionGfxs.Rows.Add(ActionGfxs.Rows.Count.ToString());
                    ecm.Actions[ind].EventCount++;
                }
                ActionGfxs.CurrentCell = ActionGfxs.Rows[ActionGfxs.Rows.Count - 1].Cells[0];
            }
            else
            {
                int ind = Actions.CurrentRow.Index;
                ecm.Actions[ind].Gfxs.Add(new Gfx());
                ActionGfxs.Rows.Add(ActionGfxs.Rows.Count.ToString());
                ecm.Actions[ind].EventCount++;
                ActionGfxs.CurrentCell = ActionGfxs.Rows[ActionGfxs.Rows.Count - 1].Cells[0];
            }
        }

        private void CloneActionSfx_Click(object sender, EventArgs e)
        {
            if (ActionSfxs.CurrentRow == null || Actions.CurrentRow == null) return;
            if (ActionSfxs.CurrentRow.Index == -1 || Actions.CurrentRow.Index == -1) return;
            int ind = Actions.CurrentRow.Index;
            var indexes = ActionSfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderBy(f => f).ToList();
            foreach (var item in indexes)
            {
                MemoryStream st = new MemoryStream();
                st.Position = 0;
                StreamWriter sw = new StreamWriter(st);
                ecm.Actions[ind].Sfx[item].Save(sw, ecm.Version);
                sw.Flush();
                st.Seek(0, SeekOrigin.Begin);
                ecm.Actions[ind].Sfx.Add(new Sfx(new StreamReader(st), ecm.Version, true));
                ActionSfxs.Rows.Add(ActionSfxs.Rows.Count);
                ecm.Actions[ind].EventCount++;
            }
            ActionSfxs.CurrentCell = ActionSfxs.Rows[ActionSfxs.Rows.Count - 1].Cells[0];
        }

        private void CopyActionSfx_Click(object sender, EventArgs e)
        {
            if (ActionSfxs.CurrentRow == null) return;
            if (ActionSfxs.CurrentRow.Index == -1) return;
            MemoryStream st = new MemoryStream();
            st.Position = 0;
            StreamWriter sw = new StreamWriter(st);
            ecm.Actions[Actions.CurrentRow.Index].Sfx[ActionSfxs.CurrentRow.Index].Save(sw, ecm.Version);
            sw.Flush();
            st.Seek(0, SeekOrigin.Begin);
            Clipboard.SetText(new StreamReader(st).ReadToEnd());
        }

        private void PasteActionSfx_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actions.CurrentRow == null) return;
                if (Actions.CurrentRow.Index == -1) return;
                ecm.Actions[Actions.CurrentRow.Index].Sfx.Add(new Sfx(new StreamReader(GenerateStreamFromString(Clipboard.GetText()), Encoding.UTF8), ecm.Version, true));
                ecm.Actions[Actions.CurrentRow.Index].EventCount++;
                ActionSfxs.Rows.Add((object)(ActionSfxs.Rows.Count + 1));
                ActionEventCount.Text = ecm.Actions[Actions.CurrentRow.Index].EventCount.ToString();
            }
            catch
            {

            }
        }

        private void DeleteActionSfx_Click(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || ActionSfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionSfxs.CurrentRow.Index == -1) return;
            int actindex = Actions.CurrentRow.Index;
            var indexes = ActionSfxs.SelectedRows.Cast<DataGridViewRow>().Select(m => m.Index).OrderByDescending(f => f).ToList();
            foreach (var item in indexes)
            {
                ActionSfxs.Rows.RemoveAt(item);
                ecm.Actions[actindex].Sfx.RemoveAt(item);
                ecm.Actions[actindex].EventCount--;
            }
        }

        private void AddActionGfxFxFile_Click(object sender, EventArgs e)
        {
            if (Actions.CurrentRow == null || ActionGfxs.CurrentRow == null) return;
            if (Actions.CurrentRow.Index == -1 || ActionGfxs.CurrentRow?.Index == -1) return;

            int ind = Actions.CurrentRow.Index;
            int ind1 = ActionGfxs.CurrentRow.Index;
            ecm.Actions[ind].Gfxs[ind1].FxFiles.Add("");
            ActionsGfxFxFiles.Rows.Add("");
        }
    }
}