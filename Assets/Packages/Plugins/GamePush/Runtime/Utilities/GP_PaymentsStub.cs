namespace Packages.Plugins.GamePush.Runtime.Utilities
{
    using System.Collections.Generic;
    using Packages.Plugins.GamePush.Runtime.Modules;
    using UnityEngine;

    [CreateAssetMenu(fileName = "GP_PaymentsStub", menuName = "GP_Settings/GP_PaymentsStub")]
    public class GP_PaymentsStub : ScriptableObject
    {
        [SerializeField] private List<FetchProducts> products = new();
        [SerializeField] private List<FetchPlayerPurchases> purchases = new();

        public IReadOnlyList<FetchProducts> Products => products;
        public IReadOnlyList<FetchPlayerPurchases> Purchases => purchases;
    }
}