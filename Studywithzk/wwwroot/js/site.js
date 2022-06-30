$(window).on('load', function () {
    var url = window.location.pathname,
        urlRegExp = new RegExp(url.replace(/\/$/, '') + "$"); // create regexp to match current url pathname and remove trailing slash if present as it could collide with the link in navigation in case trailing slash wasn't present there
    // now grab every link from the navigation
    $('.navigation-main a').each(function () {
        // and test its normalized href against the url pathname regexp
        if (urlRegExp.test(this.href.replace(/\/$/, ''))) {
            $(this).parent('li').addClass('active');
        }
        if (urlRegExp.test(this.href.replace(/\/$/, ''))) {
            $(this).parents('li.nav-item').addClass('sidebar-group-active open');
        }
    });
});

$(document).ready(function () {
    var table = $('#datatable').DataTable({
        //"dom": 'Blfrtip',
        "lengthMenu": [
            [100, 1000, -1],
            [100, 1000, "All"]
        ],
        "initComplete": function () {
            $("#datatable").show();
        },
        "buttons": ['copy', 'excel', 'pdf', 'print']
    });
    table.buttons().container().appendTo('#datatable_wrapper .col-md-6:eq(0)');
    $('#datatable tfoot th').each(function () {
        var title = $(this).text();
        if (title != "Action") {
            $(this).html(`<div class="position-relative"><input type="text" class="searchformcontrol" placeholder=""><span class="searchspan"><i data-feather='search'></i></span></div>`);
        } else {
            $(this).html('');
        }

    });
    // DataTable
    table.columns().every(function () {
        var that = this;

        $('input', this.footer()).on('keyup change', function () {
            if (that.search() !== this.value) {
                that
                    .search(this.value)
                    .draw();
            }
        });
    });
});

