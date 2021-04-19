const msgloading = "Loading";
const msgLoadingWait = "I will close in a moment";

/**
 * Add or edit element. Return modal view
 * @param {number} itemId
 * @param {string} itemClass (Controller)
 */
async function AddEditElements(itemId, itemClass) {
    let url;
    if (itemId > 0) {
        url = `/${itemClass}/Edit/${itemId}`;
    }
    else {
        url = `/${itemClass}/Create`;
    }

    Swal.fire({
        title: msgloading,
        text: msgLoadingWait,
        onBeforeOpen: () => {
            Swal.showLoading()
        },
        allowOutsideClick: false,
        allowEscapeKey: false,
        showConfirmButton: false
    });

    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $("#detailsItemsModalDiv").html(data);
        $("#detailsItemsModal").modal("show");
        Swal.close();
    } else {
        Swal.fire({
            icon: "error",
            title: "Oops!",
            text: "Something went wrong"
        });
    }
}

/**
 * Details Elements. Return modal view
 * @param {number} itemId
 * @param {string} itemClass (Controller)
 */
async function DetailsElements(itemId, itemClass) {
    let url;
    if (itemId > 0) {
        url = `/${itemClass}/Details/${itemId}`;
    }
    else {
        url = `/${itemClass}/Create`;
    }

    Swal.fire({
        title: msgloading,
        text: msgLoadingWait,
        onBeforeOpen: () => {
            Swal.showLoading()
        },
        allowOutsideClick: false,
        allowEscapeKey: false,
        showConfirmButton: false
    });

    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $("#detailsItemsModalDiv").html(data);
        $("#detailsItemsModal").modal("show");
        Swal.close();
    } else {
        Swal.fire({
            icon: "error",
            title: "Oops!",
            text: "Something went wrong"
        });
    }
}

/**
 * Delete Element
 * @param {number} itemId
 * @param {string} itemClass (Controller)
 */
async function DeleteElement(itemId, itemClass) {
    const url = `/${itemClass}/Delete/${itemId}`;
    const ans = await Swal.fire({
        title: `Do you want to delete item: "${itemId}". Are you sure?`,
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!',
        allowOutsideClick: false,
        allowEscapeKey: false,
        focusCancel: true
    });

    if (ans.isConfirmed) {
        Swal.fire({
            title: msgloading,
            text: msgLoadingWait,
            onBeforeOpen: () => {
                Swal.showLoading()
            },
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: false
        });

        const request = await fetch(url, {
            method: "DELETE"
        });

        if (request.ok) {
            await GetElements(itemClass);
            await Swal.fire({
                title: 'Deleted!',
                text: 'Your record has been deleted.',
                icon: 'success',
                timer: 5000,
                timerProgressBar: true
            });

        } else {
            Swal.fire({
                icon: "error",
                title: "Oops!",
                text: "Something went wrong"
            });
        }
    }
}


/**
 * Get Elements. Return modal view
 * @param {string} itemClass (Controller)
 */
async function GetElements(itemClass) {
    const url = `/${itemClass}/`;

    Swal.fire({
        title: msgloading,
        text: msgLoadingWait,
        onBeforeOpen: () => {
            Swal.showLoading()
        },
        allowOutsideClick: false,
        allowEscapeKey: false,
        showConfirmButton: false
    });

    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $("#detailsItemsModalDiv").html(data);
        $("#detailsItemsModal").modal("show");
        Swal.close();
    } else {
        Swal.fire({
            icon: "error",
            title: "Oops!",
            text: "Something went wrong"
        });
    }
}

/**
 * Toggle Login
 * */
function ToggleLogin() {
    $('#register').modal('hide');
    $('#login').modal('show');
}

/**
 * Toggle Register
 * */
function ToggleRegister() {
    $('#login').modal('hide');
    $('#register').modal('show');
}

/** Table Config  **/
$(function () {
    $('#table').searchable({
        striped: true,
        oddRow: { 'background-color': '#f5f5f5' },
        evenRow: { 'background-color': '#fff' },
        searchType: 'fuzzy'
    });

    $('#searchable-container').searchable({
        searchField: '#container-search',
        selector: '.row',
        childSelector: '.col-xs-4',
        show: function (elem) {
            elem.slideDown(100);
        },
        hide: function (elem) {
            elem.slideUp(100);
        }
    })
});

/** Listeners  **/
const $frmRegister = document.querySelector("#frmRegister");
if ($frmRegister) {
    $frmRegister.addEventListener('submit', async (event) => {
        event.preventDefault();
        if (!$($frmRegister).valid()) {
            return;
        }

        let $renderRegisterLoading = document.querySelector("#renderRegisterLoading");
        $renderRegisterLoading.innerHTML = `<i class="fa fa-refresh fa-spin fa-5x fa-fw"></i><span class="lead">Processing...</span>`;
        const registerRequest = await fetch('/Account/Register/', {
            method: "POST",
            body: new FormData($frmRegister)
        });

        if (registerRequest.ok) {
            $frmRegister.reset();
            const result = await registerRequest.text();
            if (result == 'true') {
                $renderRegisterLoading.innerHTML = `<div class="alert alert-success" role="alert">Register Successful! <br> <a class="btn btn-outline-primary m-0 float-right" href="#" onclick="ToggleLogin()"><i class="fa fa-user"></i> LogIn</a></div>`;
            } else {
                $renderRegisterLoading.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
            }
        } else {
            if (registerRequest.status == 400) {
                $renderRegisterLoading.innerHTML = `<div class="alert alert-info" role="alert">Username is already Taken <a class="btn btn-outline-primary m-0 float-right" href="#" onclick="ToggleLogin()"><i class="fa fa-user"></i> Login</a></div>`;
            } else {
                $renderRegisterLoading.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
            }
        }
    });
}