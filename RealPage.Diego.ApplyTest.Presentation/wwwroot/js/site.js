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
    const url = `/${itemClass}/Details/${itemId}`;
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
 * Render Episodes
 * @param {number} showId
 * @param {string} itemClass
 * @param {string} renderSectionId
 */
async function RenderEpisodes(showId, itemClass, renderSectionId) {
    const url = `/${itemClass}/Episodes/${showId}`;
    const $renderDivId = document.getElementById(renderSectionId);
    $renderDivId.innerHTML = `<div class='text-center'><i class="fas fa-spinner fa-spin fa-5x fa-fw"></i><br><span class="lead">Loading...</span></div>`;
    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $renderDivId.innerHTML = data;
    } else {
        $renderDivId.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
    }
}

async function RenderEpisodesByDate(showId, itemClass, renderSectionId) {
    let url;
    const { value: date } = await Swal.fire({
        title: 'Input Date',
        input: 'text',
        inputLabel: 'Date',
        inputPlaceholder: 'YYYY-MM-DD',
        inputValidator: (value) => {
            if (!value) {
                return 'You need to write something!'
            }
        }
    });

    
    if (date) {
        url = `/${itemClass}/EpisodesByDate/${showId}?date=${date}`;
    } else {
        return
    }

    const $renderDivId = document.getElementById(renderSectionId);
    $renderDivId.innerHTML = `<div class='text-center'><i class="fas fa-spinner fa-spin fa-5x fa-fw"></i><br><span class="lead">Loading...</span></div>`;
    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $renderDivId.innerHTML = data;
    } else {
        $renderDivId.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
    }
}




/**
 * Render Seasons
 * @param {any} showId
 * @param {any} itemClass
 * @param {any} renderSectionId
 */
async function RenderSeasons(showId, itemClass, renderSectionId) {
    const url = `/${itemClass}/Seasons/${showId}`;
    const $renderDivId = document.getElementById(renderSectionId);
    $renderDivId.innerHTML = `<div class='text-center'><i class="fas fa-spinner fa-spin fa-5x fa-fw"></i><br><span class="lead">Loading...</span></div>`;
    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $renderDivId.innerHTML = data;
    } else {
        $renderDivId.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
    }
}

async function RenderCast(showId, itemClass, renderSectionId) {
    const url = `/${itemClass}/Cast/${showId}`;
    const $renderDivId = document.getElementById(renderSectionId);
    $renderDivId.innerHTML = `<div class='text-center'><i class="fas fa-spinner fa-spin fa-5x fa-fw"></i><br><span class="lead">Loading...</span></div>`;
    const request = await fetch(url);
    if (request.ok) {
        const data = await request.text();
        $renderDivId.innerHTML = data;
    } else {
        $renderDivId.innerHTML = `<div class="alert alert-danger" role="alert"> Something went wrong. 😥 </div>`;
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
