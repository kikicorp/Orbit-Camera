    private void RotateCamera()
    {
    game.virtualCamera.transform.RotateAround(
            game.bricks.LastOrDefault().transform.position,
            new Vector3(0f, 1f, 0),
            20 * Time.deltaTime * 20f);
    }
    
