 private CharacterController cc;
   			private float jumpheight=0f;
   			private bool decrease=false;
    void Start()
    {
        cc=GetComponent<CharacterController>();
    }

    void Update()
    {
             if (cc.isGrounded == false) 
             {
			  cc.Move (new Vector3(0,-7.4f,0) * Time.deltaTime);
              decrease=true;
             }
            if (Input.GetButtonDown("Jump")&&cc.isGrounded)                         ///if grounded and pressed jump 
            {
               
               jumpheight=20.5f;                                                        //change the required variables
               decrease=true;
            }
            cc.Move(new Vector3(0,jumpheight,0)*Time.deltaTime);
            
            if(cc.isGrounded)                                                           //if grounded reset the variables to avoid wierdness
            {
                decrease=false;
                jumpheight=0;                
            }
 }
    void FixedUpdate()
    {
    if(decrease)
    {                                                        
        jumpheight=jumpheight-0.55f;                                            //Sorry,Sir Newton......
    }        
    }