using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//    private bool canDash = true;
//    private bool isDashing;
//    private float dashingPower = 28f;
//    private float dashingTime = 0.25f;
//    private float dashingCooldown = 0.5f;

// if (isDashing)
//        {
//            return;
//        }

//        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
//        {
//            StartCoroutine(Dash());
//        }

//        if (isDashing)
//       {
//            return;
//        }

//    private IEnumerator Dash()
//    {
//        canDash = false;
//        isDashing = true;
//        float originalGravity = rb.gravityScale;
//        rb.gravityScale = 0f;
//        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
//        tr.emitting = true;
//        yield return new WaitForSeconds(dashingTime);
//        tr.emitting = false;
//        rb.gravityScale = originalGravity;
//        isDashing = false;
//        yield return new WaitForSeconds(dashingCooldown);
//        canDash = true;
//    }