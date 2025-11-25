$(document).ready(function () {

    // ============================
    //     DATATABLES GLOBAL
    // ============================
    const $table = $("#table");

    if ($table.length) {
        $table.DataTable({
            ordering: true,
            paging: true,
            searching: true,
            language: {
                emptyTable: "Nenhum registro encontrado",
                info: "Mostrando _START_ a _END_ de _TOTAL_ registros",
                infoEmpty: "Mostrando 0 a 0 de 0 registros",
                infoFiltered: "(Filtrado de _MAX_ registros)",
                lengthMenu: "Mostrar _MENU_ por página",
                loadingRecords: "Carregando...",
                processing: "Processando...",
                search: "Pesquisar:",
                zeroRecords: "Nenhum registro encontrado",
                paginate: {
                    next: "Próximo",
                    previous: "Anterior",
                    first: "Primeiro",
                    last: "Último"
                }
            }
        });
    }

    // ============================
    // FECHAR ALERTAS
    // ============================
    $(document).on("click", ".btn-close, .close-alert", function () {
        $(this).closest(".alert").fadeOut(200);
    });

});
