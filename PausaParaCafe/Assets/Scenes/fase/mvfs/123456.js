#pragma script

var cliclou: Boolean;

var PosAnt: Vector3;

function Start() {
    clicou = false;
}

function Update() {

    if (Input.GetMouseButtonUp(0){

        clicou = false;

    }

    if (clicou) {

        guiTexture.pixelInset.x += Input.mousePosition.x - PosAnt.x;
        guiTexture.pixelInset.y += Input.mousePosition.y - PosAnt.y;
        PosAnt = Input.mousePosition;

    }

}

function OnMouseOver() {

    if (Input.GetMouseButtonDown(0){

        clicou = true;
        PosAnt = Input.mousePosition;

    }


}