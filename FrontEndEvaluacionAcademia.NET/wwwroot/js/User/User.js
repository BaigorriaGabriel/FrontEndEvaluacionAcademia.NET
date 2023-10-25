//var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ3ZWJBcGlTdWJqZWN0IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoiZ2FiaS4yOTEyQGhvdG1haWwuY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIxIiwiZXhwIjoxNjk4ODY0NTQyfQ.F5MxYOAmXUzFNIMWylHBoROxz_WGWcAvMDLxRwtn9Iw";
var token = getCookie("Token");

let table = new DataTable('#Users', {

    ajax: {
        url: `https://localhost:7168/api/User/GetAllActive`,
        //dataSrc: "data.items",
        dataSrc: "data",
        headers: { "Authorization": "Bearer " + token }
    },

    columns: [
        { data: 'codUser', title: 'Codigo' },
        { data: 'name', title: 'Nombre' },
        { data: 'email', title: 'Email' },
        { data: 'dni', title: 'DNI' },
        //{
        //    data: function (data) {
        //        var butons =
        //            `<td><a href='javascript:UpdateUser(${JSON.stringify(data)})'><i class="fa-solid fa-pen-to-square editarUsuario"></i></td>` +
        //            `<td><a href='javascript:DeleteUser(${JSON.stringify(data)})'><i class="fa-solid fa-trash eliminarUsuario"></i></td>`
        //        return butons;
        //    }
        //}
    ]

});


function Register() {
    $.ajax({
        type: "POST",
        url: "/Users/UsersAddPartial",
        data: "",
        contentType: 'application/json',
        'dataType': "html",
        success: function (resultado) {
            $('#UsersAddPartial').html(resultado);
            $('#userModal').modal('show');
        }
    });
}