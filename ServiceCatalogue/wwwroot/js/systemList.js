



$(document).ready(function () {





    $('#DT_load').DataTable({



        "ajax": {
            "url": "?handler=SystemsAll",
            "type": "GET",
            "dataSrc": '',
            "dataSrc": '',
            "datatype": "jsonp",

        },
        
        "columns": [
            
            { "data": "Name", "name": "Name", "width": "10%" },
            { "data": "Website", "name": "Website", "width": "10%" },
            { "data": "Wiki", "name": "Wiki", "width": "10%" },
            { "data": "LastDeployed", "displayFormat": "yyyy-MM-dd", "name": "Last Deployed", "width": "10%" },
            { "data": "ServerAssets.ServerName", "name": "Server Name", "width": "10%" },
            
            
            
        
        {
            "data": "Id",
            "render": function (data) {

                return `<div class="text-center">
                        <a href="RumenTest/AppPages/Update?id=${data}" class='btn btn-success text-white' style='cursor:pointer; width:70px;'>
                            Update
                        </a>
                        &nbsp;
                        <a href="RumenTest/AppPages/Delete?id=${data}" class='btn btn-danger text-white' style='cursor:pointer; width:70px;'>
                            Delete
                        </a>
                        </div>`;
            }, "width": "40%"

            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });

});

