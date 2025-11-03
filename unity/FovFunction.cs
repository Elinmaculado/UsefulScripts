private bool PlayerInFOV()
    {
        Vector3 dirToPlayer = (playerTransform.position - transform.position).normalized;

        if (distanceToPlayer > viewDistance)
            return false;

        float angleToPlayer = Vector3.Angle(transform.forward, dirToPlayer);
        if (angleToPlayer > viewAngle / 2f)
            return false;

        if (Physics.Raycast(transform.position, dirToPlayer, out RaycastHit hit, distanceToPlayer))
        {
            if (hit.collider.gameObject == player)
                return true;

            return false;
        }

        return false;
    }

    // Esto se lo pedí al GPTo para poder visualizar las cosas xd
    void OnDrawGizmosSelected()
    {
        // Radio de visión
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, viewDistance);

        // Límites del ángulo de visión
        Vector3 leftBoundary = Quaternion.Euler(0, -viewAngle / 2f, 0) * transform.forward;
        Vector3 rightBoundary = Quaternion.Euler(0, viewAngle / 2f, 0) * transform.forward;

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + leftBoundary * viewDistance);
        Gizmos.DrawLine(transform.position, transform.position + rightBoundary * viewDistance);

        // Línea hacia el jugador
        if (playerTransform != null)
        {
            Gizmos.color = PlayerInFOV() ? Color.red : Color.gray;
            Gizmos.DrawLine(transform.position, playerTransform.position);
        }
    }