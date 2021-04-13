$(document).ready(function () {

      {
        var cargo = document.getElementById("cargo").value;
        var $filanueva = $("#filaPrincipal").clone().removeAttr('id');
        $('.cargo', $filanueva).val(cargo);
        $('#agregar', $filanueva).addClass('remove').html('Eliminar').removeClass('btn-success').addClass('btn-danger').removeAttr('id');
        //$('#cargo', $filanueva).attr('disabled', true);
        $('#cargo', $filanueva).removeAttr('id');
        $('#span.error', $filanueva).remove();
        $('#EmpleadoCargos').append($filanueva[0]);
    });

    $('#EmpleadoCargos').on("click", ".remove", function () {
        $(this).parents("tr").remove();
    });


    $("#crearEmpleado").click(function () {
        var listaCargos = [];
        $('#EmpleadoCargos tr').each(function () {
            var item = {
                CargoId: parseInt($('select.cargo', this).val())
            }
            listaCargos.push(item);
        });

        const object = {
            Cargos: listaCargos
        };

        fetch('@Url.Action("CreateDetails","Empleados")', {
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, *cors, same-origin
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            credentials: 'same-origin', // include, *same-origin, omit
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            body: JSON.stringify(object)
        })
            .then(resp => resp.json())
            .then(resp => {
                if (resp.data == "ok") {
                    setTimeout(
                        function () {
                            window.location.href = "@Url.Action('Index','Empleados')";
                        }, 4000);
                    Swal.fire({
                        //position: 'top-end',
                        icon: 'success',
                        title: 'empleado guardado',
                        showConfirmButton: false,
                        timer: 1500
                    })
                } else {
                    Swal.fire('¡Error al guardar!', '', 'info')
                }
            })
            .catch(err => {
                Swal.fire('¡Error al guardar!', '', 'info')
            })

    });

    









        $("#crearEmpleado111111111").click(function () {

            //Encabezado el empleado

            var isValid = true;
            var url = $(this).data('url');

            var imagen = $("#imagen").prop("files");
            var formData = new FormData();
            formData.append("Nombre", document.getElementById("nombre").value);
            formData.append("Documento", document.getElementById("documento").value);
            formData.append("Telefono", document.getElementById("telefono").value);
            formData.append("Imagen", imagen[0]);

            if (document.getElementById("nombre").value == '') {
                $('#nombre').siblings('span.error').text('Ingrese el nombre');
                isValid = false;
            } else {
                $('#nombre').siblings('span.error').text('');
            }

            if (document.getElementById("telefono").value == '') {
                $('#telefono').siblings('span.error').text('Ingrese el teléfono');
                isValid = false;
            } else {
                $('#telefono').siblings('span.error').text('');
            }

            if (document.getElementById("documento").value == '') {
                $('#documento').siblings('span.error').text('Ingrese el documento');
                isValid = false;
            } else {
                $('#documento').siblings('span.error').text('');
            }

            if (isValid) {

                Swal.fire({
                    title: '¿Desea guardar el empleado?',
                    showDenyButton: true,
                    showCancelButton: true,
                    confirmButtonText: `Guardar`,
                    denyButtonText: `No guardar`,
                }).then((result) => {
                    if (result.isConfirmed) {


                        $.ajax({
                            type: "POST",
                            //url: "Empleados/Create",
                            //url: '@Url.Action("Create","Empleados")',
                            url: url,
                            contentType: false,
                            processData: false,
                            data: formData,
                            success: function (result) {

                                if (result.data == "ok") {

                                    Swal.fire('Empleado guardado!', '', 'success')

                                } else {
                                    Swal.fire('Error al guardar', '', 'info')

                                }
                            },
                            error: function (err) {

                                Swal.fire('Error al guardar', '', 'info')
                            }
                        });


                    } else if (result.isDenied) {
                        Swal.fire('no se guardó el empleado', '', 'info')
                    }
                })


            }//fin del isvalid

        }); // fin boton crearEmpleado






    



});// fin del document ready