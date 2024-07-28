using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UIF
{
    public partial class ItemList : Form
    {
        private List<Item> items;
        private Control[] paramsBoxes;

        private ResourceManager CurrentMainRM, CurrentAdditionalRM;

        Item selectedItem = null;

        public ItemList(List<Item> _items)
        {
            if (_items == null)
            {
                MessageBox.Show(Localization.CurrentAdditional.GetStringSafety("ItemListIsNull") +
                    Localization.CurrentAdditional.GetStringSafety("ErrorDiscordSuffix"));
            }
            else
            {
                InitializeComponent();

                for (int i = 0; i < _items.Count; i++)
                    ResultsListBox.Items.Add(_items[i].GetValue("name") + " (" + _items[i].GetValue("id") + ")");

                items = _items;

                paramsBoxes = Misc.GetAllControls(ItemStatsPanel, c => c.GetType() == typeof(TextBox)).ToArray();
            }

            _UpdateLocalization();
        }

        public void OnLocalizationChange(ResourceManager MainRM, ResourceManager AdditionalRM)
        {
            CurrentMainRM = MainRM;
            CurrentAdditionalRM = AdditionalRM;
        }

        private void _UpdateLocalization() => Localization.UpdateLocalization(this);

        private void UpdateItemList()
        {
            ResultsListBox.Items.Clear();

            for (int i = 0; i < items.Count; i++)
                ResultsListBox.Items.Add(items[i].GetValue("name") + " (" + items[i].GetValue("id") + ")");
        }

        private void ClearTextBoxes()
        {
            foreach (Control control in paramsBoxes)
                ((TextBox)control).Clear();
        }

        private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultsListBox.SelectedIndex == -1)
            {
                NameTextBox.Clear();
                IdTextBox.Clear();

                ClearTextBoxes();
            }
            else
            {
                ClearTextBoxes();

                selectedItem = items[ResultsListBox.SelectedIndex];

                IdTextBox.Text = selectedItem.GetValue("id");
                NameTextBox.Text = selectedItem.GetValue("name");

                foreach (TextBox control in paramsBoxes)
                    control.Text = selectedItem.FormatKey(control.Name);
            }
        }

        private void IdToClipboard_Click(object sender, EventArgs e)
        {
            if (ResultsListBox.SelectedIndex != -1)
                Clipboard.SetText(
                    ((IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                    + items[ResultsListBox.SelectedIndex].GetValue("id")).Trim()
                );
        }

        private void NameIdToClipboard_Click(object sender, EventArgs e)
        {
            if (ResultsListBox.SelectedIndex != -1)
                Clipboard.SetText(
                    (
                        items[ResultsListBox.SelectedIndex].GetValue("name")
                        + " - "
                        + (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                        + items[ResultsListBox.SelectedIndex].GetValue("id")
                    )
                    .Trim()
                );
        }

        private void AllNameIdToClipboard_Click(object sender, EventArgs e)
        {
            string copyStr = string.Empty;

            for (int i = 0; i < items.Count; i++)
            {
                copyStr += (
                    items[i].GetValue("name")
                    + " - "
                    + (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                    + items[i].GetValue("id")
                )
                .Trim() + (i < items.Count ? "\n" : string.Empty);
            }

            Clipboard.SetText(copyStr);
        }

        private void GuidToClipboard_Click(object sender, EventArgs e)
        {
            if (ResultsListBox.SelectedIndex != -1)
                Clipboard.SetText(
                    ((IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                    + items[ResultsListBox.SelectedIndex].GetValue("guid")).Trim()
                );
        }

        private void NameGuidToClipboard_Click(object sender, EventArgs e)
        {
            if (ResultsListBox.SelectedIndex != -1)
                Clipboard.SetText(
                    (
                        items[ResultsListBox.SelectedIndex].GetValue("name")
                        + " - "
                        + (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                        + items[ResultsListBox.SelectedIndex].GetValue("guid")
                    )
                    .Trim()
                );
        }

        private void AllNameGuidToClipboard_Click(object sender, EventArgs e)
        {
            string copyStr = string.Empty;

            for (int i = 0; i < items.Count; i++)
            {
                copyStr += (
                    items[i].GetValue("name")
                    + " - "
                    + (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
                    + items[i].GetValue("guid")
                )
                .Trim() + (i < items.Count - 1 ? "\n" : string.Empty);
            }

            Clipboard.SetText(copyStr);
        }


        private void SortCapacityBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

            UpdateItemList();
        }

        private void SortProtectionBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

            UpdateItemList();
        }

        private void SortDamagePlayersBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

            UpdateItemList();
        }

        private void MixBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            items.Sort((a, b) => random.Next(int.MinValue, int.MaxValue));

            UpdateItemList();
        }

        private void SortDamageBuildingsBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

            UpdateItemList();
        }

        private void NameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();

        private void IdLabel_Click(object sender, EventArgs e) => IdTextBox.Focus();

        private void SortVehicleHealthBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

            UpdateItemList();
        }

        private void SortBarricadeCapacityBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureCapacity));

            UpdateItemList();
        }

        private void SortByBuildingHealthBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

            UpdateItemList();
        }

        private void SortBySpreadBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Spread));

            UpdateItemList();
        }

        private void SortByBarrelDamageBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelDamage));

            UpdateItemList();
        }

        private void LinkedAmmoBtn_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                List<Item> linked = selectedItem.GetLinked("ammo");
                if (linked != null && linked.Count > 0)
                {
                    linked.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));
                    new ItemList(linked).Show();
                }
                else
                {
                    MessageBox.Show("This item doesn't have linked");
                }
            }
        }

        private void LinkedModulesBtn_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                List<Item> linked = selectedItem.GetLinked("modules");
                if (linked != null && linked.Count > 0)
                    new ItemList(linked).Show();
                else
                    MessageBox.Show("This item doesn't have linked");
            }
        }

        private void LinkedGunsBtn_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                List<Item> linked = selectedItem.GetLinked("guns");
                if (linked != null && linked.Count > 0)
                {
                    linked.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
                    new ItemList(linked).Show();
                }
                else
                {
                    MessageBox.Show("This item doesn't have linked");
                }
            }
        }

        private void SortByAmmoAmountBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));

            UpdateItemList();
        }

        private void SortByPelletsBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => (b.GetValue("type") == "Magazine" ? b.GetValue("pellets", "1").ToInt() : 1)
            .CompareTo(a.GetValue("type") == "Magazine" ? a.GetValue("pellets", "1").ToInt() : 1));

            UpdateItemList();
        }

        private void SortByRecoilYBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Recoil_Y));

            UpdateItemList();
        }

        private void SortByRecoilXBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Recoil_X));

            UpdateItemList();
        }

        private void SortByEMSMBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.EMSM));

            UpdateItemList();
        }

        private void SortByMSMBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.MSM));

            UpdateItemList();
        }

        private void SortByRangeBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Range));

            UpdateItemList();
        }

        private void SortByFirerateBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Firerate));

            UpdateItemList();
        }

        private void SortByIDBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) =>
            {
                int idA = int.TryParse(a.GetValue("id"), out var tempA) ? tempA : int.MaxValue;
                int idB = int.TryParse(b.GetValue("id"), out var tempB) ? tempB : int.MaxValue;

                return isSortedAscending ? idA.CompareTo(idB) : idB.CompareTo(idA);
            });

            isSortedAscending = !isSortedAscending; // Переключаем флаг сортировки
            UpdateItemList();
        }


        private void SortByNameBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d+");

            items.Sort((a, b) =>
            {
                var matchA = regex.Match(a.GetValue("name", ""));
                int numberA = matchA.Success ? int.Parse(matchA.Value) : int.MaxValue;

                var matchB = regex.Match(b.GetValue("name", ""));
                int numberB = matchB.Success ? int.Parse(matchB.Value) : int.MaxValue;

                int numberComparison = isSortedAscending ? numberA.CompareTo(numberB) : numberB.CompareTo(numberA);
                if (numberComparison != 0)
                    return numberComparison;

                return isSortedAscending ? String.Compare(a.GetValue("name", ""), b.GetValue("name", "")) : String.Compare(b.GetValue("name", ""), a.GetValue("name", ""));
            });

            isSortedAscending = !isSortedAscending; // Переключаем флаг сортировки
            UpdateItemList();
        }

        private void SortByVolumeBtn_Click(object sender, EventArgs e)
        {
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelVolume));

            UpdateItemList();
        }

        private IEnumerable<string> GetAllCalibers(Item item)
        {
            var patterns = new List<string>
                {
                    @"caliber_\d+",
                    @"attachment_caliber_\d+",
                    @"magazine_caliber_\d+",
                    @"\bcaliber\b",
                    
                };

            var calibers = new List<string>();

            foreach (var pattern in patterns)
            {
                calibers.AddRange(item
                    .Where(prop => Regex.IsMatch(prop.Key, pattern))
                    .Select(prop => prop.Value.ToString()));
            }

            return calibers.Distinct();
        }

        public List<Item> SearchForMagazines(List<Item> allItems)
        {
            return allItems.Where(item => item.GetValue("type").Equals("Magazine", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void SearchAmmoCaliberBtn_Click(object sender, EventArgs e)
        {
            var searchQuery = CaliberIDFinderBox.Text.ToLower();
            var allItems = Core.ParseAll(Folders.CheckedFolders);
            var magazineItems = SearchForMagazines(allItems);

            var filteredItems = magazineItems.Where(item =>
            {
                var allCalibers = GetAllCalibers(item);
                return allCalibers.Any(caliber => caliber.ToLower().Equals(searchQuery));
            }).ToList();

            new ItemList(filteredItems).ShowDialog();
        }


        public List<Item> SearchForModules(List<Item> allItems)
        {
            var moduleTypes = new List<string> { "Grip", "Barrel", "Sight", "Tactical" };
            return allItems.Where(item => moduleTypes.Contains(item.GetValue("type"), StringComparer.OrdinalIgnoreCase)).ToList();
        }

        private void SearchModulesCaliberBtn_Click(object sender, EventArgs e)
        {
            var searchQuery = CaliberIDFinderBox.Text.ToLower();
            var allItems = Core.ParseAll(Folders.CheckedFolders);
            var modulesItems = SearchForModules(allItems);

            var filteredItems = modulesItems.Where(item =>
            {
                var allCalibers = GetAllCalibers(item);
                return allCalibers.Any(caliber => caliber.ToLower().Equals(searchQuery));
            }).ToList();

            new ItemList(filteredItems).ShowDialog();
        }

        public List<Item> SearchForGuns(List<Item> allItems)
        {
            return allItems.Where(item => item.GetValue("type").Equals("Gun", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void SearchGunsCaliberBtn_Click(object sender, EventArgs e)
        {
            var searchQuery = CaliberIDFinderBox.Text.ToLower();
            var allItems = Core.ParseAll(Folders.CheckedFolders);
            var gunItems = SearchForGuns(allItems);

            var filteredItems = gunItems.Where(item =>
            {
                var allCalibers = GetAllCalibers(item);
                return allCalibers.Any(caliber => caliber.ToLower().Equals(searchQuery));
            }).ToList();

            new ItemList(filteredItems).ShowDialog();
        }

        private void AllIdToClipboard_Click(object sender, EventArgs e)
        {
            string copyStr = string.Empty;

            for (int i = 0; i < items.Count; i++)
            {
                copyStr += (
                    items[i].GetValue("id")
                )
                .Trim() + (i < items.Count - 1 ? "\n" : string.Empty);
            }

            Clipboard.SetText(copyStr);
        }

        private void AllNameToClipboard_Click(object sender, EventArgs e)
        {
            string copyStr = string.Empty;

            for (int i = 0; i < items.Count; i++)
            {
                copyStr += (
                    items[i].GetValue("name")
                )
                .Trim() + (i < items.Count - 1 ? "\n" : string.Empty);
            }

            Clipboard.SetText(copyStr);
        }

        private void AllIdNameInfoTableBtn_Click(object sender, EventArgs e)
        {
            string copyStr = "ID\tНазвание\tТип\tИнформация о Предмете\n";

            foreach (var item in items)
            {
                string id = item.GetValue("id");
                string name = item.GetValue("name");
                string type = item.GetValue("type");

                string itemInfo = GetItemInfoByType(item, type);

                copyStr += $"{id}\t{name}\t{type}\t{itemInfo}\n";
            }

            Clipboard.SetText(copyStr);
        }

        private string GetItemInfoByType(Item item, string itemType)
        {
            switch (itemType.ToLower())
            {
                case "gun":
                case "melee":
                    return $"ДМГ Голова: {item.FormatKey("player_skull_damage")}, Тело: {item.FormatKey("player_spine_damage")}, Дальность: {item.FormatKey("range")}";
                case "hat":
                case "glasses":
                    return $"Защита: {item.FormatKey("armor")}";
                case "pants":
                case "shirt":
                case "mask":
                case "backpack":
                case "vest":
                    return $"Защита: {item.FormatKey("armor")}, Вместительность: {item.FormatKey("item_capacity")}";
                case "sight":
                case "tactical":
                case "grip":
                case "barrel":
                case "magazine":
                case "optic":
                case "food":
                case "water":
                case "medical":
                case "fuel":
                case "tool":
                case "fisher":
                case "refill":
                case "cloud":
                case "map":
                case "key":
                case "box":
                case "arrest_start":
                case "arrest_end":
                case "vehicle_repair_tool":
                case "tire":
                case "compass":
                case "oil_pump":
                    return $"Прочность: {item.FormatKey("health")}";
                case "housing_planner":
                    return "Это инструмент.";
                case "barricade":
                case "structure":
                    return $"Прочность: {item.FormatKey("health")}";
                case "storage":
                    return $"Прочность: {item.FormatKey("health")}, Вместительность: {item.FormatKey("item_capacity")}";
                default:
                    return "Неизвестный тип предмета.";
            }
        }



        private bool isSortedAscending = true;
    }
}
