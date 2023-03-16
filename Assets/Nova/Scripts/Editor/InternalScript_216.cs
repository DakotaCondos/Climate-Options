using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    internal class InternalType_581 : AdvancedDropdown
    {
        public event System.Action<Type> InternalEvent_6;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<string, int> InternalField_3312 = new Dictionary<string, int>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<Type> InternalField_3313 = new List<Type>();

        public InternalType_581(Type InternalParameter_78) : base(new AdvancedDropdownState())
        {
            TypeCache.TypeCollection InternalVar_1 = TypeCache.GetTypesDerivedFrom(InternalParameter_78);

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Count; ++InternalVar_2)
            {
                Type InternalVar_3 = InternalVar_1[InternalVar_2];

                if (InternalVar_3.IsAbstract)
                {
                    continue;
                }

                if (InternalField_3312.TryGetValue(InternalVar_3.Name, out int InternalVar_4))
                {
                    InternalVar_4++;
                }
                else
                {
                    InternalVar_4 = 1;
                }

                InternalField_3312[InternalVar_3.Name] = InternalVar_4;
                InternalField_3313.Add(InternalVar_3);
            }

            InternalField_3313.Sort(new InternalType_497());
        }

        protected override AdvancedDropdownItem BuildRoot()
        {
            var InternalVar_1 = new AdvancedDropdownItem("Select Type");

            int InternalVar_2 = 0;

            InternalVar_1.AddChild(new InternalType_496(null, "None (Unassigned)")
            {
                id = InternalVar_2++
            });

            for (int InternalVar_3 = 0; InternalVar_3 < InternalField_3313.Count; ++InternalVar_3)
            {
                Type InternalVar_4 = InternalField_3313[InternalVar_3];

                string InternalVar_5 = InternalVar_4.Name;

                if (InternalField_3312[InternalVar_4.Name] > 1)
                {
                    string InternalVar_6 = InternalVar_4.Assembly.ToString().Split('(', ',')[0];
                    InternalVar_5 = $"{InternalVar_4.Name} [{InternalVar_4.Namespace}, Assembly: {InternalVar_6}]";
                }

                var InternalVar_7 = new InternalType_496(InternalVar_4, InternalVar_5)
                {
                    id = InternalVar_2++,
                };

                InternalVar_1.AddChild(InternalVar_7);
            }

            return InternalVar_1;
        }

        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            base.ItemSelected(item);

            if (!item.enabled)
            {
                return;
            }

            if (item is InternalType_496 typePopupItem)
            {
                InternalEvent_6?.Invoke(typePopupItem.InternalProperty_244);
            }
        }

        private struct InternalType_497 : IComparer<Type>
        {
            public int Compare(Type x, Type y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        private class InternalType_496 : AdvancedDropdownItem
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Type InternalProperty_244 { get; }

            public InternalType_496(Type InternalParameter_38, string InternalParameter_3093) : base(InternalParameter_3093)
            {
                InternalProperty_244 = InternalParameter_38;
            }
        }
    }
}

