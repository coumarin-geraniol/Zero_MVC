var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/order/getall' },
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'name', "width": "20%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'applicationUser.email', "width": "15%" },
            {
                data: 'orderStatus',
                "width": "10%",
                "render": function (data) {
                    var statusClass = '';
                    switch (data) {
                        case 'Pending':
                            statusClass = 'secondary';
                            break;
                        case 'Approved':
                            statusClass = 'warning';
                            break;
                        case 'Processing':
                            statusClass = 'info';
                            break;
                        case 'Shipped':
                            statusClass = 'success';
                            break;
                        case 'Cancelled':
                        case 'Refunded':
                            statusClass = 'danger';
                            break;
                    }
                    return `<span class="badge bg-${statusClass}">${data}</span>`;
                }
            },
            {
                data: 'orderTotal',
                "width": "12%",
                "render": function (data) {
                    var formatter = new Intl.NumberFormat('en-US', {
                        style: 'currency',
                        currency: 'TRY',
                    });
                    return `<span class="text-primary">${formatter.format(data)}</span>`;
                }
            },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/order/details?orderId=${data}" class="btn btn-success mx-2 opacity-75"> <i class="bi bi-pencil-square"></i> Edit</a>                                    
                    </div>`
                },
                "width": "30%"
            }
        ]
    });
}


  