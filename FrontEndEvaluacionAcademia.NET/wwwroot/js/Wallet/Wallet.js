var token = getCookie("Token");

let table = new DataTable('#WalletPeso', {

    ajax: {
        url: `https://localhost:7168/api/Account/GetAccountByType?codUser=1&type=1`,
        //dataSrc: "data.items",
        dataSrc: "data",
        headers: { "Authorization": "Bearer " + token }
    },

    columns: [
        { data: 'codAccount', title: 'Codigo' }
    ]

});